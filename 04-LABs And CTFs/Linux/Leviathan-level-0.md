<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Leviathan : level 0</title><style>
      * {
        font-family: Georgia, Cambria, "Times New Roman", Times, serif;
      }
      html, body {
        margin: 0;
        padding: 0;
      }
      h1 {
        font-size: 50px;
        margin-bottom: 17px;
        color: #333;
      }
      h2 {
        font-size: 24px;
        line-height: 1.6;
        margin: 30px 0 0 0;
        margin-bottom: 18px;
        margin-top: 33px;
        color: #333;
      }
      h3 {
        font-size: 30px;
        margin: 10px 0 20px 0;
        color: #333;
      }
      header {
        width: 640px;
        margin: auto;
      }
      section {
        width: 640px;
        margin: auto;
      }
      section p {
        margin-bottom: 27px;
        font-size: 20px;
        line-height: 1.6;
        color: #333;
      }
      section img {
        max-width: 640px;
      }
      footer {
        padding: 0 20px;
        margin: 50px 0;
        text-align: center;
        font-size: 12px;
      }
      .aspectRatioPlaceholder {
        max-width: auto !important;
        max-height: auto !important;
      }
      .aspectRatioPlaceholder-fill {
        padding-bottom: 0 !important;
      }
      header,
      section[data-field=subtitle],
      section[data-field=description] {
        display: none;
      }
      </style></head><body><article class="h-entry">
<header>
<h1 class="p-name">Leviathan : level 0</h1>
</header>
<section data-field="subtitle" class="p-summary">
OverTheWire
</section>
<section data-field="body" class="e-content">
<section name="962d" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="00ae" id="00ae" class="graf graf--h3 graf--leading graf--title">Leviathan : level 0</h3><p name="5a30" id="5a30" class="graf graf--p graf-after--h3">OverTheWire</p><figure name="6645" id="6645" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*FOdhsAAxh1Wq7bT6UdFN5A.png" data-width="1063" data-height="565" src="https://cdn-images-1.medium.com/max/800/1*FOdhsAAxh1Wq7bT6UdFN5A.png"><figcaption class="imageCaption">Leviathan</figcaption></figure><h3 name="181b" id="181b" class="graf graf--h3 graf-after--figure">Dare you face the lord of the oceans?</h3><p name="e471" id="e471" class="graf graf--p graf-after--h3">Leviathan is a wargame that has been rescued from the demise of <strong class="markup--strong markup--p-strong">intruded.net</strong>, previously hosted on leviathan.intruded.net. <strong class="markup--strong markup--p-strong">Big thanks to adc, morla and reth</strong> for their help in resurrecting this game!</p><pre data-code-block-mode="1" spellcheck="false" data-code-block-lang="vbnet" name="25f9" id="25f9" class="graf graf--pre graf-after--p graf--preV2"><span class="pre--content"><span class="hljs-symbol">Description:</span><br />This wargame doesn<span class="hljs-comment">&#x27;t require any knowledge about programming - just a bit of common</span><br />sense <span class="hljs-built_in">and</span> some knowledge about basic *nix commands. We had no idea that it<span class="hljs-comment">&#x27;d be this</span><br />hard <span class="hljs-keyword">to</span> make an interesting wargame that wouldn<span class="hljs-comment">&#x27;t require programming abilities from </span><br />the players. Hopefully we made an interesting challenge <span class="hljs-keyword">for</span> the <span class="hljs-built_in">new</span> ones.</span></pre><p name="b75e" id="b75e" class="graf graf--p graf-after--pre">Leviathan’s levels are called <strong class="markup--strong markup--p-strong">leviathan0, leviathan1, … etc.</strong> and can be accessed on <strong class="markup--strong markup--p-strong">leviathan.labs.overthewire.org</strong> through SSH on port 2223.</p><p name="0585" id="0585" class="graf graf--p graf-after--p">To login to the first level use:</p><pre data-code-block-mode="1" spellcheck="false" data-code-block-lang="css" name="be4d" id="be4d" class="graf graf--pre graf-after--p graf--preV2"><span class="pre--content">ssh -<span class="hljs-selector-tag">p</span> <span class="hljs-number">2223</span> leviathan0<span class="hljs-keyword">@leviathan</span>.labs.overthewire.org<br /><span class="hljs-attribute">Password</span>: leviathan0</span></pre><p name="900d" id="900d" class="graf graf--p graf-after--pre">Data for the levels can be found in <strong class="markup--strong markup--p-strong">the homedirectories</strong>. You can look at <strong class="markup--strong markup--p-strong">/etc/leviathan_pass</strong> for the various level passwords.</p><figure name="3730" id="3730" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*ZBpRILQaDT3UXvVYwXACxA.png" data-width="560" data-height="320" src="https://cdn-images-1.medium.com/max/800/1*ZBpRILQaDT3UXvVYwXACxA.png"></figure><p name="ce39" id="ce39" class="graf graf--p graf-after--figure">As usual, we did not find visible files, so we used -a, to show the files,Then we found this file named bookmarks.html ,When I first tried to read the files, I learned that it was huge</p><figure name="d527" id="d527" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*g2gSUA1JtJieQSiKSB43Yw.png" data-width="392" data-height="58" src="https://cdn-images-1.medium.com/max/800/1*g2gSUA1JtJieQSiKSB43Yw.png"></figure><p name="b3a5" id="b3a5" class="graf graf--p graf-after--figure">So I used wc :</p><figure name="b737" id="b737" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*YqVJfN1Cd9c7NSVdr2sizA.png" data-width="543" data-height="86" src="https://cdn-images-1.medium.com/max/800/1*YqVJfN1Cd9c7NSVdr2sizA.png"></figure><p name="9b95" id="9b95" class="graf graf--p graf-after--figure">Here I read the file using cat, and output anything with the name password .</p><blockquote name="1df1" id="1df1" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">See you soon in other reports….!!</em></strong></blockquote><blockquote name="3dad" id="3dad" class="graf graf--blockquote graf-after--blockquote"><em class="markup--em markup--blockquote-em">Abdelwahab_Shandy</em></blockquote><blockquote name="2ecd" id="2ecd" class="graf graf--blockquote graf-after--blockquote graf--trailing"><em class="markup--em markup--blockquote-em">AS_Cyber</em></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/62745b716d3a"><time class="dt-published" datetime="2023-12-07T00:24:22.216Z">December 7, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/leviathan-level-0-62745b716d3a" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>