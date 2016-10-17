# NodeJSWebApp

用于测试NodeJS性能的代码

# 如何使用？

```bash
# 安装依赖
$ npm i

# Express框架，不带cluster（单核）
$ node express-app.js

# Express框架，带cluster（多核）
$ node server-express.js

# Koa框架，不带cluster（单核）
$ node koa-app.js

# Koa框架，带cluster（多核）
$ node server-koa.js
```