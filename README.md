
### Set Up Your Git Repo

Again in a terminal / command line in the main solution directory, type:

```
git --version

```

If you get an error you probably don’t have git installed.

we want to set up our local git repository by typing:

```
git init
```

This should initialize a local git repository in the solution directory that will track the code changes in a hidden folder called: `.git`

Now type:

```
git status
```

This will show you all the “un-tracked” files in your directory, (basically files that are not under source control), at this stage that is everything.

Ok we want to track “everything”, (except those files ignored!), to so type:

```
git add .
```

Finally, we want to “commit” the changes, (essentially lock them in), by typing:

```
git commit -m "Initial Commit"
git status
```

We have basically placed our solution under local source control and have committed all our “changes” to our master branch in our 1st commit.

we need to configure a “remote Git repository” and push to from our local machine

```
git remote add origin https://cameleer.visualstudio.com/DefaultCollection/ECommerce/_git/ECommerce
git push -u origin --all
```

IMPORTANT: You may get asked to authenticate when you issue the 2nd command.