# Working routine

## Building one feature (vertical slice)
1. Pick ONE small screen or action (e.g. list people).
2. DAL: add the data method. Build. Commit `feat(dal): ...`
3. BL: add the service method that uses it. Build. Commit `feat(bl): ...`
4. UI: add the screen that calls the BL. Build. Run. Commit `feat(classic): ...`
5. Push.

## Before every commit
- `git status`: only the files I expect, no bin/obj.
- Solution builds with no errors.
- One commit = one idea, describable without "and".

## When stuck
- Make the smallest version that works, then grow it.
- Rebuild the solution after every move or rename.

## Milestones
- Tag after a working screen: `git tag v0.2-people-list`