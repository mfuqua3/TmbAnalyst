const path = require('path');
const glob = require('glob');
const webpack = require('webpack');

module.exports = (env) => {
    const base = {
        entry: glob.sync('./Scripts/{**/*.cshtml.ts, index.ts}' +
            '').reduce((obj, el) => {
            obj[path.parse(el).name] = el;
            return obj;
        }, {}),
        module: {
            rules: [{
                test: /\.tsx?$/,
                loader: 'ts-loader',
                exclude: /node_modules/,
            },
                {
                    test: /\.css$/,
                    use: [
                        'style-loader',
                        'css-loader'
                    ]
                }]
        },
        // plugins: [
        //     new webpack.ProvidePlugin({
        //         $: 'jquery',
        //         jQuery: 'jquery',
        //         'window.jQuery': 'jquery'
        //     })]
        // ,
        resolve: {
            modules: ["node_modules"],
            extensions: ['.tsx', '.ts', '.js'],
        },
        devtool: 'source-map',
        mode: 'production',
        output: {
            path: path.resolve(__dirname, 'wwwroot/dist'),
            filename: (pathData, assetInfo) => {
                const name = pathData.chunk.name;
                const pageExtIdx = name.indexOf('.cshtml');
                let fn = name;
                if(pageExtIdx>0){
                    fn = name.substring(0,pageExtIdx) + 'Page';
                }
                return `${fn}.js`;
            }
        }
    }
    if (env.development) {
        base.mode = 'development';
        base.devServer = {
            static: {
                directory: path.join(__dirname, 'wwwroot/dist'),
            },
            compress: true,
            port: 9000,
        }
    }
    return base;
};