var gulp=require('gulp'); //local gulp
var sourcemaps = require('gulp-sourcemaps') //sourcemaps
var uglify = require('gulp-uglify') //minify the js
var concat = require('gulp-concat') //concat the js files.
var uglifycss = require('gulp-uglifycss') //minify the css
var ts = require("gulp-typescript"); //compiles typescript
var sass = require('gulp-sass'); //Converts sass to css
//var autoprefixer = require('gulp-autoprefixer');
var concatUtil = require('gulp-concat-util');
var addsrc = require('gulp-add-src');

var distFolder = 'dist'

gulp.task('default', ['appjs','js-lib','appcss','fonts']);

// compile ts files
//  name: name of target file
//  src: glob[] containing ts files
var compileTs = function (name, src) {
    return gulp.src(src)
        .pipe(sourcemaps.init())
        .pipe(ts({
            target: 'es5',
            sortOutput: true
        }))
        .pipe(concat(name))
        .pipe(sourcemaps.write('.'))
        .pipe(gulp.dest(distFolder))
}

// compile ts folder ts files
tsGlob = ['app/**/*.ts*', "typings/**/*ts*"]
gulp.task('appjs', function (cb) {
    return compileTs('app.js', tsGlob)
})

// compile third party libraries
gulp.task('js-lib', function () {
    gulp.src([
            'node_modules/jquery/dist/jquery.js',
            'node_modules/bootstrap/dist/js/bootstrap.js',
            //'node_modules/respond/main.js',
            'node_modules/jquery-validation/dist/jquery.validate.js',
            'node_modules/npm-modernizr/modernizr.js',
            'node_modules/angular/angular.js',
            'node_modules/angular-route/angular-route.js',
        ])
        .pipe(concat('js-lib.js'))
        .pipe(gulp.dest(distFolder))
})

gulp.task('appcss', function () {
    return gulp.src([
        'css/site.scss',
        'node_modules/bootstrap/dist/css/bootstrap.css',
        'node_modules/bootstrap/dist/css/bootstrap-theme.css'
        ])
        .pipe(sourcemaps.init())
        .pipe(concat('app.css'))
        .pipe(sourcemaps.write('.'))
        .pipe(gulp.dest(distFolder))
})


gulp.task('fonts', function () {
    return gulp.src('node_modules/bootstrap/fonts/**/*')
        .pipe(gulp.dest('fonts'))
})

// gulp.task('staticContent', function () {
//     gulp.src('mercer/assets/mobile/**/*').pipe(gulp.dest(distFolder + '/mobile/'))
//     gulp.src('mercer/assets/*.png').pipe(gulp.dest(distFolder))
//     gulp.src('mercer/assets/*.ico').pipe(gulp.dest(distFolder))
//     return gulp.src('mercer/assets/fonts/**/*', {
//             base: 'mercer/assets'
//         })
//         .pipe(gulp.dest(distFolder))
// })
