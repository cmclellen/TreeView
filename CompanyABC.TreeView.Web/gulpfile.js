var gulp = require('gulp'),
    ngHtml2Js = require("gulp-ng-html2js");

gulp.task("html", function () {
    gulp.src("./app/**/*.html")
    .pipe(ngHtml2Js({
        moduleName: "app.tree-view.partials",
        prefix: "/partials/"
    }))
    .pipe(gulp.dest("./dist/partials"));
});

gulp.task("default", ["html"]);

