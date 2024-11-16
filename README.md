# PlaySoundCS

This silly project demonstrates how to play an MP3 file using LibVLCSharp in a C# console application.


## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/en-us/download)
- [LibVLCSharp library](https://github.com/videolan/libvlcsharp?tab=readme-ov-file#installation) 


## Installation

1. Install the .NET Core SDK from the [official website](https://dotnet.microsoft.com/download).
2. Add the LibVLCSharp library to your project by running the following command:
    ```sh
    dotnet add package LibVLCSharp
    dotnet add package VideoLAN.LibVLC.Windows
    ```


## Usage

1. Clone the repository or download the source code.
2. Navigate to the project directory.
3. Build the project:
    ```sh
    dotnet build
    ```
4. Run the project with the path to an MP3 file as an argument:
    ```sh
    dotnet run -- "path/to/your/file.mp3"
    ```


## License

Do whatever you want