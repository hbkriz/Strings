# Running this locally using CLI

> Install latest .Net Core SDK (if not available) from [here](https://dotnet.microsoft.com/download).

> Check dotnet version using command if its already installed. The current project is developed using 5.0 version of .Net Core SDK:

dotnet --info

> After cloning the project in CLI, to run tests execute the below command from 'cd .\Strings\Strings.Test', this should ideally restore, build and test at the sametime:

dotnet test
