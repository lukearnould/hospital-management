const esbuild = require('esbuild');

function bundleCSS() {
    esbuild.build({
        logLevel: 'info',
        entryPoints: ['wwwroot/css/app.css'],
        bundle: true,
        minify: true,
        outfile: 'wwwroot/css/app.bundle.css'
    }).catch(() => process.exit(1));
}

function bundleJS() {
    esbuild.build({
        logLevel: 'info',
        entryPoints: ['wwwroot/js/app.js'],
        bundle: true,
        minify: true,
        sourcemap: true,
        outfile: 'wwwroot/js/app.bundle.js'
    }).catch(() => process.exit(1));
}

bundleCSS();
bundleJS();