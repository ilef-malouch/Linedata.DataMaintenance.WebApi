FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine

ENV ASPNETCORE_URLS=http://+:5000 \
    DOTNET_RUNNING_IN_CONTAINER=true \
    DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=true \
    COMPlus_EnableDiagnostics=0

RUN addgroup -S app && \
    adduser -S app \
            -G app \
            -s /bin/bash

USER app
WORKDIR /home/app

COPY --chown=app:app ./publish/Linedata.My.Service.Host/netcoreapp3.1/ /home/app/.

EXPOSE 12000
EXPOSE 5000

HEALTHCHECK --interval=5s --timeout=10s --retries=3 CMD curl --fail http://localhost:5000/health || exit 1
ENTRYPOINT ["dotnet", "/home/app/Linedata.My.Service.Host.dll"]
