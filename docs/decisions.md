# Design decisions

## 2026-11-02: Layered solution with two interfaces
Two UIs (Classic, Modern) share one BL and one DAL, so business logic is written once.
Both UIs reference only the BL.

## 2026-11-02: Fresh repository
Started a new repository for a clean structure. The old prototype repo (`dvld-winforms`)
is kept as a reference; pieces of it are imported manually, one at a time.

## 2026-11-02: Commit convention
`type(scope): description`, with scopes naming the project that changed.