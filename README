Project for APBD Course.


## APBD - Tutorial 1 Answers

### 1. When does Git perform a fast-forward and when is a merge commit created?
A **fast-forward** occurs when the base branch (e.g., `main`) has no new commits since the feature branch was created. Git simply moves the pointer forward. A **merge commit** is created when the two branches have diverged (both have new, independent commits), requiring a new commit to tie the two histories together.

### 2. What is the practical difference between merge and rebase?
**Merge** preserves the entire history, including the chronological "forks" and junctions, which is great for seeing exactly how/when features were integrated. **Rebase** rewrites the history by moving the feature branch's commits to the tip of the main branch, creating a clean, linear history that looks like the work happened sequentially.

### 3. How was the conflict resolved in your repository?
In Task 7, a conflict occurred in `Program.cs` because the title message was modified differently on both `main` and `feature-conflict`. I resolved it by manually editing the file to remove the Git conflict markers (`<<<<`, `====`, `>>>>`) and choosing a final version of the code that combined/corrected the logic, then staged the change with `git add` and finalized the merge with a commit.