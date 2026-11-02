# DVLD

Desktop application for managing a Driving & Vehicle License Department (DVLD):
people, drivers, applications and licenses. Built with C# WinForms on .NET Framework 4.8.

> **Status:** project skeleton only. No features are implemented yet.

## Solution structure

| Project | Type | Role | References |
|---|---|---|---|
| `DVLD.DAL` | Class Library | Database access only | none |
| `DVLD.BL` | Class Library | Business rules and logic | `DVLD.DAL` |
| `DVLD.UI.Classic` | WinForms App | Classic user interface | `DVLD.BL` |
| `DVLD.UI.Modern` | WinForms App | Modern user interface | `DVLD.BL` |

```text
UI.Classic ─┐
            ├──► BL ──► DAL ──► Database
UI.Modern  ─┘
```

Both interfaces share the same business and data layers. Pick the startup project to choose
which interface runs.

Rules:
- A UI never references the DAL and contains no SQL.
- The BL contains no forms, controls or message boxes.
- The DAL knows nothing except the database.
- Anything needed by both interfaces belongs in the BL, not in a UI project.

## Getting started

1. Install Visual Studio 2022 with the **.NET desktop development** workload.
2. Open `DVLD.slnx`.
3. Set `DVLD.UI.Classic` or `DVLD.UI.Modern` as the startup project and press `F5`.

## Documentation

- Design decisions: [`docs/decisions.md`](docs/decisions.md)
- Working routine: [`docs/workflow.md`](docs/workflow.md)

## Commit convention

`type(scope): description`

- Types: `feat`, `fix`, `refactor`, `docs`, `chore`
- Scopes: `sln`, `dal`, `bl`, `classic`, `modern`