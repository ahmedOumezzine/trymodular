﻿"use strict";

var gulp = require('gulp'),
    clean = require('gulp-clean'),
    glob = require("glob"),
    argv = require('yargs').argv;

var buildConfigurationName = argv.configurationName || 'Debug';

var paths = {
    host: {
        wwwroot: "./wwwroot/",
        wwwrootModules: "./wwwroot/modules/",
        modules: "./Modules/",
        moduleBin: "/bin/"
    },
    dev: {
        modules: "../Modules/",
        moduleBin: "/bin/" + buildConfigurationName +"/netcoreapp2.2/"
    }
};

var modules = loadModules();

function loadModules() {
    var moduleManifestPaths,
        modules = [];

    moduleManifestPaths = glob.sync(paths.dev.modules + '*.*/module.json', {});
    moduleManifestPaths.forEach(function (moduleManifestPath) {
        var moduleManifest = require(moduleManifestPath);
        modules.push(moduleManifest);
    });

    return modules;
}

gulp.task('clean-module', function () {
    return gulp.src([paths.host.modules + '*', paths.host.wwwrootModules + '*'], { read: false })
        .pipe(clean());
});
gulp.task('copy-static', function () {
    modules.forEach(function (module) {
        console.log('copying static contents ' + paths.dev.modules + module.id);
        gulp.src([paths.dev.modules + module.id ,
        paths.dev.modules + module.id + '/module.json'], { base: module.id })
            .pipe(gulp.dest(paths.host.modules + module.id));
        gulp.src(paths.dev.modules + module.id + '/wwwroot/**/*.*')
            .pipe(gulp.dest(paths.host.wwwrootModules + module.id.split(".").pop().toLowerCase()));
    });

    gulp.src(paths.dev.modules + 'SimplCommerce.Module.SampleData/SampleContent/**/*.*')
        .pipe(gulp.dest(paths.host.modules + 'SimplCommerce.Module.SampleData/SampleContent'));
});
gulp.task('copy-modules', ['clean-module'], function () {
    

    modules.forEach(function (module) {
        if (!module.isBundledWithHost) {
            console.log('copy-modules ' + paths.dev.modules + module.id + paths.dev.moduleBin);
            console.log('copy-modules ' + paths.host.modules + module.id + paths.host.moduleBin);
            gulp.src(paths.dev.modules + module.id + paths.dev.moduleBin + '**/*.*')
                .pipe(gulp.dest(paths.host.modules + module.id + paths.host.moduleBin));
        }
    });
});
