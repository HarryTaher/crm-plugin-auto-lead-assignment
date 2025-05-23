# Dynamics CRM Plugin: Auto Lead Assignment

A simple plugin that auto-assigns new leads to a fixed user.

## Technologies
- C#
- Microsoft Dynamics CRM SDK

## How to Use
1. Build the project in Visual Studio as a Class Library (.NET Framework).
2. Use Plugin Registration Tool to register this plugin.
3. Register it on the "Create" message of the "lead" entity.
4. Replace the GUID in the code with a valid system user GUID in your CRM.

## Disclaimer
This is a simplified example for educational purposes.
