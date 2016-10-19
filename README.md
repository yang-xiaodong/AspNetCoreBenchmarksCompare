# AspNetCoreBenchmarksCompare
About ASP.NET Core helloworld project benchmarks compare with ASP.NET、Python django、NodeJS、Java servlet on Windows and Linux. 

编号|对比方 | 系统环境 | 宿主环境 | 测试结果（QPS）
---|---|---|---|---
1|`ASP.NET Core` vs `ASP.NET Core` | Windows | `Kestrel` vs `IIS` | 45.6k vs 15.2k
2|`ASP.NET Core` vs `ASP.NET` | Windows | `IIS` vs `IIS` | 15.2k vs 18.2k
3|`ASP.NET Core` vs `ASP.NET`  | Windows | `Kestrel` vs `IIS` | 45.6k vs 18.2k
4|`ASP.NET Core` vs `Python Django` | Linux | `Kestrel` vs `uwsgi` | 26.7k vs 1.57k
5|`ASP.NET Core` vs `Java Servlet` | Linux | `Kestrel` vs `Tomcat` | 26.7k vs 18.3k
6-1|`ASP.NET Core` vs `NodeJS Express` | Linux | `Kestrel` vs `self host` | 26.7k vs 15.6k
6-2|`ASP.NET Core` vs `NodeJS Koa` | Linux | `Kestrel` vs `self host` | 26.7k vs 17.5k

![image](http://images2015.cnblogs.com/blog/250417/201610/250417-20161017161425795-251964624.png)
