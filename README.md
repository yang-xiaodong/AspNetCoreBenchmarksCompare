# AspNetCoreBenchmarksCompare

About ASP.NET Core helloworld project benchmarks compare with ASP.NET、Python django、NodeJS、Java servlet on Windows and Linux. 

### Linux 

编号|对比方 | 系统环境 | 宿主环境 | 测试结果（QPS）
---|---|---|---|---
1|`ASP.NET Core` vs `Python Django` | Linux | `Kestrel` vs `uwsgi` | 26.7k vs 1.57k
2|`ASP.NET Core` vs `Java Servlet` | Linux | `Kestrel` vs `Tomcat` | 26.7k vs 18.3k
3-1|`ASP.NET Core` vs `NodeJS Express` | Linux | `Kestrel` vs `self host` | 26.7k vs 15.6k
4-2|`ASP.NET Core` vs `NodeJS Koa` | Linux | `Kestrel` vs `self host` | 26.7k vs 17.5k
5|`ASP.NET Core` vs `ASP.NET Core` | Linux vs Nano server | `Kestrel` vs `Kestrel` | 26.7k vs 27.7k

### Windows

编号|对比方 | 系统环境 | 宿主环境 | 测试结果（QPS）
---|---|---|---|---
1|`ASP.NET Core` vs `ASP.NET Core` | Windows | `Kestrel` vs `IIS` | 45.6k vs 15.2k
2|`ASP.NET Core` vs `ASP.NET Core` | Windows | `Kestrel` vs `WebListener` | 35.5k vs 27.9k
3|`ASP.NET Core` vs `ASP.NET` | Windows | `IIS` vs `IIS` | 15.2k vs 18.2k
4|`ASP.NET Core` vs `ASP.NET`  | Windows | `Kestrel` vs `IIS` | 45.6k vs 18.2k

======== update 1 2016-10-19 ==========

add `ASP.NET Core Linux vs Nano server` test.

======== update 2 2016-12-30 ==========

add `ASP.NET Core Kestrel vs WebListener` test.

---

![image](http://images2015.cnblogs.com/blog/250417/201610/250417-20161017161425795-251964624.png)
