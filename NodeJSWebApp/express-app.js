const express = require('express');
const app = express();

app.get('/', function (req, res) {
  res.send('Hello World!\n Express!');
});

app.listen(1337, () => {
  console.log('Server running at http://127.0.0.1:1337/');
}).on('error', err => {
  console.error('error', err);
});