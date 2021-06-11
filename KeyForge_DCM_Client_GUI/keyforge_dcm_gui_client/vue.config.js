module.exports = {
    devServer: {
      proxy: {
        '^/api': {
          target: 'http://localhost:27282',
          changeOrigin: true
        }
      }
    }
  }