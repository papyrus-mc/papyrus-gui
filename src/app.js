const { app, BrowserWindow } = require( 'electron' );
const path = require( 'path' );

module.exports = () => {
    function createWindow() {
        let win = new BrowserWindow( {
            width:  800,
            height: 600,
            webPreferences: {
                nodeIntegration: true
            }
        } );

        win.loadFile( './src/index.html' );
    };

    app.on( 'ready', createWindow );
};