# AspNetCoreBenchmarksCompare
About ASP.NET Core helloworld project benchmarks compare with ASP.NET、Python django、NodeJS、Java servlet on Windows and Linux. 

编号|对比方 | 系统环境 | 宿主环境 | 测试目标
---|---|---|---|---
1|`ASP.NET Core` vs `ASP.NET Core` | Windows | `Kestrel` vs `IIS` | 相同平台**不同宿**主间性能差距
2|`ASP.NET Core` vs `ASP.NET` | Windows | `IIS` vs `IIS` | 相同平台相同宿主**不同框架**间性能差距
3|`ASP.NET Core` vs `ASP.NET`  | Windows | `Kestrel` vs `IIS` | 相同平台**不同宿主不同框架**间性能差距
4|`ASP.NET Core` vs `Python Django` | Linux | `Kestrel` vs `uwsgi` | 相同平台**不同语言不同宿主不同框架**间性能差距
5|`ASP.NET Core` vs `Java Servlet` | Linux | `Kestrel` vs `Tomcat` | 相同平台**不同语言不同宿主不同框架**间性能差距
6|`ASP.NET Core` vs `NodeJS` | Linux | `Kestrel` vs `self host` | 相同平台**不同语言不同宿主不同框架**间性能差距 

![](http://images2015.cnblogs.com/blog/250417/201610/250417-20161014174651156-1226959658.png)
