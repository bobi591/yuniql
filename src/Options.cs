﻿using CommandLine;
using System.Collections;
using System.Collections.Generic;

namespace ArdiLabs.Yuniql
{
    //https://github.com/commandlineparser/commandline
    //https://github.com/dotnet/command-line-api

    //yuniql init
    [Verb("init", HelpText = "Initialize migration structure to target folder")]
    public class InitOption
    {
        //yuniql init -p c:\temp\demo | --path c:\temp\demo
        [Option('p', "path", Required = false, HelpText = "Path to initialize")]
        public string Path { get; set; }

        //yuniql init -d | --debug
        [Option('d', "debug", Required = false, HelpText = "Print debug information including all raw scripts")]
        public bool Debug { get; set; }
    }

    //yuniql vnext
    [Verb("vnext", HelpText = "Increment to next version")]
    public class NextVersionOption
    {
        //yuniql vnext -p c:\temp\demo | --path c:\temp\demo
        [Option('p', "path", Required = false, HelpText = "Path to increment version from")]
        public string Path { get; set; }

        //yuniql vnext -M | --major
        [Option('M', "major", Required = false, HelpText = "Increment major version")]
        public bool IncrementMajorVersion { get; set; }

        //yuniql vnext -m | --minor
        [Option('m', "minor", Required = false, HelpText = "Increment minor version")]
        public bool IncrementMinorVersion { get; set; }

        //yuniql vnext -f "Table1.sql"
        [Option('f', "file", Required = false, HelpText = "Increment version and create empty .sql file")]
        public string File { get; set; }

        //yuniql vnext -d | --debug
        [Option('d', "debug", Required = false, HelpText = "Print debug information including all raw scripts")]
        public bool Debug { get; set; }
    }

    //yuniql run
    [Verb("run", HelpText = "Runs migration steps")]
    public class RunOption
    {
        //yuniql run -p c:\temp\demo | --path c:\temp\demo
        [Option('p', "path", Required = false, HelpText = "Path to run migration from")]
        public string Path { get; set; }

        //yuniql run -t v1.05 | --target-version v1.05
        [Option('t', "target-version", Required = false, HelpText = "Target version to migrate into and skipping versions greater")]
        public string TargetVersion { get; set; }

        //yuniql run -c "<connectiong-string>"
        [Option('c', "connection-string", Required = false, HelpText = "Connection string to target sql server instance", Default = "Data Source=.;Integrated Security=SSPI;Initial Catalog=YuniqlDemoDB")]
        public string ConnectionString { get; set; }

        //yuniql run -a true | --auto-create-db true
        [Option('a', "auto-create-db", Required = false, HelpText = "Create database automatically")]
        public bool AutoCreateDatabase { get; set; }

        //yuniql run -d | --debug
        [Option('d', "debug", Required = false, HelpText = "Print debug information including all raw scripts")]
        public bool Debug { get; set; }

        //yuniql run -k "LINKSERVER1=SERVER01" -k "LINKEDSERVER2=SERVER02" -k "ANOTHERDB=DB1" | --token "..." --token "..." --token "..."
        [Option('k', "token", Required = false, HelpText = "Replace tokens using the passed key-value pairs")]
        public IEnumerable<string> Tokens { get; set; }
    }

    //yuniql info
    [Verb("info", HelpText = "Shows the current version structure of target database")]
    public class InfoOption
    {
        //yuniql info -c "<connectiong-string>"
        [Option('c', "connection-string", Required = true, HelpText = "Connection string to target sql server instance", Default = "Data Source=.;Integrated Security=SSPI;Initial Catalog=YuniqlDemoDB")]
        public string ConnectionString { get; set; }

        //yuniql run -d | --debug
        [Option('d', "debug", Required = false, HelpText = "Print debug information including all raw scripts")]
        public bool Debug { get; set; }
    }
}