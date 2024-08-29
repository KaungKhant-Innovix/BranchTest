<h1> Repo to test Git conflicts and CLI </h1>

<p> A few git cli commands are given below </p>

<h3>First clone this project</h3>

<pre><code>git clone https://github.com/KaungKhant-Innovix/BranchTest.git</code></pre> 

We decided to split by branches for each feature so I'll write down commands for that below.

<h3>Start by creating a new branch with your name <code>(eg. dev_kk)</code> </h3>

<pre><code>git checkout -b dev_kk</code></pre> 

<strong>Note:</strong><p> Notice the -b used before creating a branch. This is used to create a new branch. </p>
<p>If you want to enter an existing branch, use <code>git checkout branch_name</code> instead.

<br/>
<p>Now you can continue writing code for features that you want to change</p>
<p>It is good practice to pull code from the main branch before developing to get the latest version</p>

<pre><code>git pull origin main</code></pre>

<h3>After you finish your task or want to commit, start by adding or staging your files. Use the file name for specific files or . for all files</h3>

<h4>For all files</h4>
<pre><code>git add .</code></pre>

<h4>For single file</h4>
<pre><code>git add filename.cs</code></pre>

<h4>For multiple file, separate them with a space</h4>
<pre><code>git add filename.cs filename2.cs</code></pre>

<h3> Next we commit the file </h3>
<pre><code>git commit -m "Message"</code></pre>

<h3> After this stage, we need to push our code from our local branch to the remote branch in the repository.</h3>
<strong>Note:</strong><p>I'll use dev_kk here change that with your current branch name</p>
<pre><code>git push origin dev_kk</code></pre>

<h4>Now the updated code is added to your remote branch but it isn't in your main branch yet.</h4>

<h3> Change from our dev branch to the main branch </h3>
<pre><code>git checkout main</code></pre>

<p><strong>Note: </strong>This is the <strong>LOCAL</strong> main branch stored in your device. Not the <strong>REMOTE</strong> main branch stored on the cloud like github or bitbucket.</p>

<h3> Pull from the remote main branch to ensure up-to-date code, can skip if you're sure your main branch is updated </h3>
<pre><code>git pull origin main</code></pre>

<p>Now we are in the updated main branch and ready to merge with our dev branch. </p>

<h3>From the main branch, merge with our dev or feature branch</h3>
<pre><code>git merge dev_kk</code></pre>

<p>At this stage, if the main branch was updated during the development time in the dev branch, we might get a conflict. Github or bitbucket will show conflicting areas so resolve those first. You can use this repo to try resolving conflicts</p>

<h4> If there are no conflicts, the merge will be successful. Push the code onto the remote main branch. </h4>
<pre><code>git push</code></pre>

<h4> If there are conflicts, resolve them first, then start the commit process again </h4>
<pre><code>git add .
git commit -m "Resolved conflicts"
git push origin main
</code></pre>

<h4>This resolves the conflict and add the updated code to the main branch of our repository </h4>

