<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Digital Forensics :Cypher Anxiety</title><style>
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
<h1 class="p-name">Digital Forensics :Cypher Anxiety</h1>
</header>
<section data-field="subtitle" class="p-summary">
cybertalents
</section>
<section data-field="body" class="e-content">
<section name="fb08" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="a187" id="a187" class="graf graf--h3 graf--leading graf--title">Digital Forensics :Cypher Anxiety</h3><p name="7753" id="7753" class="graf graf--p graf-after--h3">cybertalents</p><figure name="54bb" id="54bb" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*Bhp2J1p-xD8zJeJzibA8xQ.png" data-width="966" data-height="517" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*Bhp2J1p-xD8zJeJzibA8xQ.png"></figure><h4 name="6592" id="6592" class="graf graf--h4 graf-after--figure">An image was leaked from a babies store. the manager is so annoyed because he needs to identify the image to fire charges against the responsible employee. the key is the md5 of the image</h4><p name="3866" id="3866" class="graf graf--p graf-after--h4">We will download the file using :</p><figure name="29cc" id="29cc" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*e2bq6ZZhihHcxlfGICPIZA.png" data-width="756" data-height="327" src="https://cdn-images-1.medium.com/max/800/1*e2bq6ZZhihHcxlfGICPIZA.png"></figure><p name="ae55" id="ae55" class="graf graf--p graf-after--figure">I will find out the file type first , Then I unzip the file :</p><figure name="191d" id="191d" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*QpI4uzVjiVgAcu87NVpVOA.png" data-width="576" data-height="317" src="https://cdn-images-1.medium.com/max/800/1*QpI4uzVjiVgAcu87NVpVOA.png"></figure><p name="fd51" id="fd51" class="graf graf--p graf-after--figure">After confirming here also we can use Wire Shark :</p><figure name="2b22" id="2b22" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*c2ufeJL5tPZUGHgD7sa2tg.png" data-width="737" data-height="185" src="https://cdn-images-1.medium.com/max/800/1*c2ufeJL5tPZUGHgD7sa2tg.png"></figure><p name="ad3f" id="ad3f" class="graf graf--p graf-after--figure">We will go to <strong class="markup--strong markup--p-strong">Statistics</strong> and then to <strong class="markup--strong markup--p-strong">protocol Hierarchy</strong> , Then we will specify the DATA :</p><figure name="6390" id="6390" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*hK2cp2S77Hi1owS6BLmlFg.png" data-width="1285" data-height="343" src="https://cdn-images-1.medium.com/max/800/1*hK2cp2S77Hi1owS6BLmlFg.png"></figure><p name="a797" id="a797" class="graf graf--p graf-after--figure">When you check in data, specifically and open<strong class="markup--strong markup--p-strong"> tcp stream :</strong></p><figure name="f1a1" id="f1a1" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*1n0th_UReV9o2gtQ8iRIqw.png" data-width="1366" data-height="278" src="https://cdn-images-1.medium.com/max/800/1*1n0th_UReV9o2gtQ8iRIqw.png"></figure><p name="ca2a" id="ca2a" class="graf graf--p graf-after--figure">If you notice this, it is being asked to do a listen on port 7070 , So I will make a filter for port 7070 :</p><figure name="82d8" id="82d8" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*BU6R5HpBcaGjyn12KOXvIA.png" data-width="1366" data-height="351" src="https://cdn-images-1.medium.com/max/800/1*BU6R5HpBcaGjyn12KOXvIA.png"></figure><p name="0216" id="0216" class="graf graf--p graf-after--figure">Then we will do a <strong class="markup--strong markup--p-strong">follow</strong> and then <strong class="markup--strong markup--p-strong">tcp stream :</strong></p><figure name="fbf7" id="fbf7" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*ehC-YuNfas7YL96wWsqUXA.png" data-width="1197" data-height="574" src="https://cdn-images-1.medium.com/max/800/1*ehC-YuNfas7YL96wWsqUXA.png"></figure><p name="27ee" id="27ee" class="graf graf--p graf-after--figure">We will save the file in RAW format</p><figure name="0a93" id="0a93" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*4NZ9zGf_cdoX8aUfybgFQQ.png" data-width="1031" data-height="557" src="https://cdn-images-1.medium.com/max/800/1*4NZ9zGf_cdoX8aUfybgFQQ.png"></figure><p name="8e1c" id="8e1c" class="graf graf--p graf-after--figure"><strong class="markup--strong markup--p-strong">We must remember the incident above and its summary :</strong></p><p name="418d" id="418d" class="graf graf--p graf-after--p">Hey bro<br>Sup supp, are we ready<br>yeah, u got the files?<br>yes but i think the channel is not secured<br>the UTM will block the file transfer as the DLP module is active<br>ok we can use cryptcat<br>ok what the password then<br>let it be P@ssawordaya<br>hhh, ok<br>listen on 7070 and ill send you the file , bye<br>bye</p><p name="19af" id="19af" class="graf graf--p graf-after--p">They were having a conversation with each other</p><figure name="127e" id="127e" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*-vg9qiOKmGwvVDGoPdbZpQ.png" data-width="739" data-height="191" src="https://cdn-images-1.medium.com/max/800/1*-vg9qiOKmGwvVDGoPdbZpQ.png"></figure><p name="9e3b" id="9e3b" class="graf graf--p graf-after--figure">So after saving the file in raw form :</p><p name="98b7" id="98b7" class="graf graf--p graf-after--p">We will open the ports, so say it in the conversation here</p><figure name="066f" id="066f" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*Hak_T9Jwtnns5Y2kKnvyQQ.png" data-width="730" data-height="109" src="https://cdn-images-1.medium.com/max/800/1*Hak_T9Jwtnns5Y2kKnvyQQ.png"><figcaption class="imageCaption">The first</figcaption></figure><figure name="964a" id="964a" class="graf graf--figure graf-after--figure"><img class="graf-image" data-image-id="1*M7UGdr3Vg34rOM5m2ClGQQ.png" data-width="532" data-height="72" src="https://cdn-images-1.medium.com/max/800/1*M7UGdr3Vg34rOM5m2ClGQQ.png"><figcaption class="imageCaption">the second</figcaption></figure><p name="9ed1" id="9ed1" class="graf graf--p graf-after--figure">Then if we look at the new file, we will find an image :</p><figure name="3858" id="3858" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*TAsKmYdr2MIdPVmZuimnMQ.png" data-width="738" data-height="217" src="https://cdn-images-1.medium.com/max/800/1*TAsKmYdr2MIdPVmZuimnMQ.png"></figure><p name="c655" id="c655" class="graf graf--p graf-after--figure">We will create an md5sum for the file, to bring the flag</p><figure name="a7c3" id="a7c3" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*4Y6llsoxA3Xkttxqag0QIw.png" data-width="514" data-height="98" src="https://cdn-images-1.medium.com/max/800/1*4Y6llsoxA3Xkttxqag0QIw.png"></figure><p name="36c2" id="36c2" class="graf graf--p graf-after--figure">Here is the flag</p><figure name="d58a" id="d58a" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*AP3eOXIuP3fh3xLQOL6VXQ.png" data-width="782" data-height="128" src="https://cdn-images-1.medium.com/max/800/1*AP3eOXIuP3fh3xLQOL6VXQ.png"></figure><blockquote name="2852" id="2852" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">See you soon in other reports….!!</em></strong></blockquote><blockquote name="a11a" id="a11a" class="graf graf--blockquote graf-after--blockquote">Abdelwahab_Shandy</blockquote><blockquote name="4a37" id="4a37" class="graf graf--blockquote graf-after--blockquote graf--trailing">AS_Cyber</blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/3a01ede3aee2"><time class="dt-published" datetime="2023-12-06T09:56:45.062Z">December 6, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/digital-forensics-cypher-anxiety-3a01ede3aee2" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>