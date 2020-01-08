# to build image run in PS - `docker build --pull -t conversion:examples .`
# to run tests run in PS - `docker run --rm -it -v ${PWD}:/examples/Results conversion:examples`
 
FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS buid_env

# prepare
WORKDIR /examples
COPY ./*.sln ./
COPY ./GroupDocs.Conversion.Examples.CSharp/ ./GroupDocs.Conversion.Examples.CSharp/
COPY ./GroupDocs.Conversion.Examples.CSharp.Core/ ./GroupDocs.Conversion.Examples.CSharp.Core/
# end prepare

# GroupDocs.Conversion dependency - https://docs.groupdocs.com/display/conversionnet/.NET+Standard+2.0+API+Limitations
RUN dotnet add ./GroupDocs.Conversion.Examples.CSharp.Core/GroupDocs.Conversion.Examples.CSharp.Core.csproj package SkiaSharp.NativeAssets.Linux --framework netcoreapp2.1
# GroupDocs.Conversion dependency

# restore
WORKDIR /examples
RUN dotnet restore ./GroupDocs.Conversion.Examples.CSharp.Core/GroupDocs.Conversion.Examples.CSharp.Core.csproj
# end restore

## build
WORKDIR /examples
RUN dotnet publish ./GroupDocs.Conversion.Examples.CSharp.Core/GroupDocs.Conversion.Examples.CSharp.Core.csproj --no-restore --framework netcoreapp2.1 --configuration Debug -o ./../publish_output
## end build

FROM mcr.microsoft.com/dotnet/core/runtime:2.1 

# begin GroupDocs.Conversion dependencies - https://docs.groupdocs.com/display/conversionnet/.NET+Standard+2.0+API+Limitations
RUN apt-get update && \
    DEBIAN_FRONTEND=noninteractive apt-get install -y libgdiplus && \
    DEBIAN_FRONTEND=noninteractive apt-get install -y libc6-dev

RUN apt-get update && \
    DEBIAN_FRONTEND=noninteractive apt-get install -y libfontconfig1

RUN echo "deb http://httpredir.debian.org/debian jessie main contrib" > /etc/apt/sources.list \
    && echo "deb http://security.debian.org/ jessie/updates main contrib" >> /etc/apt/sources.list \
    && echo "ttf-mscorefonts-installer msttcorefonts/accepted-mscorefonts-eula select true" | debconf-set-selections \
    && apt-get update \
    && DEBIAN_FRONTEND=noninteractive apt-get install -y ttf-mscorefonts-installer \
    && apt-get clean \
    && apt-get autoremove -y \
    && rm -rf /var/lib/apt/lists/*
# end GroupDocs.Conversion dependencies

WORKDIR /examples
COPY --from=buid_env /examples/publish_output .
ENTRYPOINT ["dotnet", "GroupDocs.Conversion.Examples.CSharp.Core.dll"]