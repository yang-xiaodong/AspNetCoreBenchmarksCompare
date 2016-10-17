const koa = require('koa');
const app = koa();

app.use(function* () {
  this.body = 'Hello World\n Koa！';
});

app.listen(1337, () => {
  console.log('Server running at http://127.0.0.1:1337/');
}).on('error', err => {
  console.error('error', err);
});