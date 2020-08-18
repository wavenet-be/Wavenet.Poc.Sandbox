const path = require('path');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const TerserJSPlugin = require("terser-webpack-plugin");
const webpack = require('webpack');
  
const DIST_DIR = path.resolve(__dirname, 'dist');
const SRC_DIR = path.resolve(__dirname, 'src');

const config = {
  mode: 'development',
  
  // File entry of the project.
  entry: {
    app: SRC_DIR + '/index.tsx'
  },
  
  // Define output directory.
  output: {
    path: DIST_DIR,
    filename: '[name].bundle.js'
  },
  
  // Enable sourcemaps for debugging webpack's output.
  devtool: 'inline-source-map',
  
  // Manage loaders rules.
  module: {
    rules: [
      {
        test: /\.(js|jsx|ts|tsx)$/,
        exclude: /node_modules/,
        use: {
          loader: "babel-loader"
        }
      }
    ]
  },
  
  resolve: {
    // Add selected extension files as resolvable extensions.
    extensions: ['.ts', '.tsx', '.js', '.json', '.jsx']
  },

  
  optimization: {
    minimizer: [
      new TerserJSPlugin({})
    ]
  },
  
//   plugins: [
//     new HtmlWebpackPlugin({
//       hash: true,
//       title: 'React with TypeScript, bundled with Webpack',
//       template: SRC_DIR + '/index.html',
//       filename: DIST_DIR + '/index.html'
//     }),
//     new webpack.NamedModulesPlugin(),
//     new webpack.HotModuleReplacementPlugin()
//   ],
  
  // Mount web server with HMR.
  devServer: {
    historyApiFallback: true,
    contentBase: DIST_DIR,
    compress: true,
    port: 9000,
    hot: true,
    inline: true
  }
};
  
module.exports = config;