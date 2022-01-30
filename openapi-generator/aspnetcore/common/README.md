# Agl.Cdr.Common - ASP.NET Core 3.1 Server

Consumer Data Standards APIs created by the Data Standards Body (DSB), with the Data Standards Chair as the decision maker to meet the needs of the Consumer Data Right

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```
## Run in Docker

```
cd src/Agl.Cdr.Common
docker build -t agl.cdr.common .
docker run -p 5000:8080 agl.cdr.common
```
