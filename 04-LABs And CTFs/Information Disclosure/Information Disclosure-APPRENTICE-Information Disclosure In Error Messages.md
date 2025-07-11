<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Information Disclosure : APPRENTICE : Information disclosure in error messages</title><style>
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
<h1 class="p-name">Information Disclosure : APPRENTICE : Information disclosure in error messages</h1>
</header>
<section data-field="subtitle" class="p-summary">
Web Security Academy &gt;&gt; Information disclosure &gt;&gt; Exploiting &gt;&gt; Lab
</section>
<section data-field="body" class="e-content">
<section name="fbd5" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="d439" id="d439" class="graf graf--h3 graf--leading graf--title">Information Disclosure <strong class="markup--strong markup--h3-strong">: </strong>APPRENTICE :<strong class="markup--strong markup--h3-strong"> Information disclosure in error messages</strong></h3><ul class="postList"><li name="4e4e" id="4e4e" class="graf graf--li graf-after--h3"><a href="https://portswigger.net/web-security" data-href="https://portswigger.net/web-security" class="markup--anchor markup--li-anchor" rel="noopener" target="_blank"><strong class="markup--strong markup--li-strong">Web Security Academy</strong></a><strong class="markup--strong markup--li-strong"> &gt;&gt; </strong><a href="https://portswigger.net/web-security/information-disclosure" data-href="https://portswigger.net/web-security/information-disclosure" class="markup--anchor markup--li-anchor" rel="noopener" target="_blank"><strong class="markup--strong markup--li-strong">Information disclosure</strong></a><strong class="markup--strong markup--li-strong"> &gt;&gt; </strong><a href="https://portswigger.net/web-security/information-disclosure/exploiting" data-href="https://portswigger.net/web-security/information-disclosure/exploiting" class="markup--anchor markup--li-anchor" rel="noopener" target="_blank"><strong class="markup--strong markup--li-strong">Exploiting</strong></a><strong class="markup--strong markup--li-strong"> &gt;&gt; </strong><a href="https://portswigger.net/web-security/information-disclosure/exploiting/lab-infoleak-in-error-messages" data-href="https://portswigger.net/web-security/information-disclosure/exploiting/lab-infoleak-in-error-messages" class="markup--anchor markup--li-anchor" rel="noopener" target="_blank"><strong class="markup--strong markup--li-strong">Lab</strong></a></li></ul><p name="807c" id="807c" class="graf graf--p graf-after--li">This lab’s verbose error messages reveal that it is using a vulnerable version of a third-party framework. To solve the lab, obtain and submit the version number of this framework.</p><figure name="2d04" id="2d04" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*wq5UsUgJZqXb7ohw5RjqzA.png" data-width="1244" data-height="660" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*wq5UsUgJZqXb7ohw5RjqzA.png"><figcaption class="imageCaption">Information disclosure in error messages</figcaption></figure><p name="3b1b" id="3b1b" class="graf graf--p graf-after--figure">First of all, do not forget that he wants us to obtain the version number of the framework , Because it is a weak version .</p><p name="4649" id="4649" class="graf graf--p graf-after--p">As a person who specializes in web testing, you must, above all else, browse the page very normally, and then do unnatural things.</p><p name="40e7" id="40e7" class="graf graf--p graf-after--p">After starting to search the page, I found that there are a number of products, and each product has a number (productId).</p><figure name="fbed" id="fbed" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*LDhpwMzsUWzLkiC1Gs8tkQ.png" data-width="1053" data-height="55" src="https://cdn-images-1.medium.com/max/800/1*LDhpwMzsUWzLkiC1Gs8tkQ.png"></figure><figure name="06a5" id="06a5" class="graf graf--figure graf-after--figure"><img class="graf-image" data-image-id="1*hx0t7zEp7ELqSqUI3y_VbQ.png" data-width="1022" data-height="54" src="https://cdn-images-1.medium.com/max/800/1*hx0t7zEp7ELqSqUI3y_VbQ.png"></figure><figure name="f9c2" id="f9c2" class="graf graf--figure graf-after--figure"><img class="graf-image" data-image-id="1*Y6w91cKZSCXlVmfpiFtCFw.png" data-width="1021" data-height="59" src="https://cdn-images-1.medium.com/max/800/1*Y6w91cKZSCXlVmfpiFtCFw.png"></figure><p name="5016" id="5016" class="graf graf--p graf-after--figure">We can also find out this using BURP :</p><figure name="1113" id="1113" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*CQLcd9ClQtYykvMzJGYahQ.png" data-width="518" data-height="693" src="https://cdn-images-1.medium.com/max/800/1*CQLcd9ClQtYykvMzJGYahQ.png"></figure><p name="f524" id="f524" class="graf graf--p graf-after--figure">So, when the productId number is changed, it gives a different value every time , These are called GET requests, or get-result requests.</p><p name="feb8" id="feb8" class="graf graf--p graf-after--p">There are other types of requests called post, and they are used when logging in to the site. In other words, they occur when data is sent from our device to the server we are talking to, or in other words, data is sent from the client to the server.</p><blockquote name="20d8" id="20d8" class="graf graf--blockquote graf-after--p"><a href="https://0a7a005304e36a5981cbdebf00cb0079.web-security-academy.net/product?productId=2" data-href="https://0a7a005304e36a5981cbdebf00cb0079.web-security-academy.net/product?productId=2" class="markup--anchor markup--blockquote-anchor" rel="noopener" target="_blank">https://0a7a005304e36a5981cbdebf00cb0079.web-security-academy.net/product?productId=<strong class="markup--strong markup--blockquote-strong">2</strong></a></blockquote><blockquote name="900a" id="900a" class="graf graf--pullquote graf-after--blockquote">/product?productId=<strong class="markup--strong markup--pullquote-strong">2</strong></blockquote><p name="d017" id="d017" class="graf graf--p graf-after--pullquote">In the end, we know that no matter how many numbers the value changes, it will give us a normal result because in the end, the numbers refer to the pages.<br>Our task here is to obtain an abnormal result, so we will change the value of the productId to something variable, using several methods.</p><figure name="4821" id="4821" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*m8IwTNCvZYJu0sOOk53K-g.png" data-width="1022" data-height="57" src="https://cdn-images-1.medium.com/max/800/1*m8IwTNCvZYJu0sOOk53K-g.png"><figcaption class="imageCaption">Congratulations, you solved the lab!</figcaption></figure><p name="2dc6" id="2dc6" class="graf graf--p graf-after--figure">The result after that will be the error message you are looking for, but I will show the error message in a stronger way than this, in the following way :</p><figure name="66f0" id="66f0" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*diUUF-5QtNpG17P_jZ2ZQg.png" data-width="671" data-height="240" src="https://cdn-images-1.medium.com/max/800/1*diUUF-5QtNpG17P_jZ2ZQg.png"><figcaption class="imageCaption">Congratulations, you solved the lab!</figcaption></figure><p name="bc31" id="bc31" class="graf graf--p graf-after--figure">Here we have made the intercept is on and we are requesting the productId and making the actual value of the productId ==AS_CYBER, and therefore the error message will be displayed when the request is forwarded.</p><h4 name="b5fd" id="b5fd" class="graf graf--h4 graf-after--p">There is another way, which I actually prefer, and the desired error message will be output :</h4><figure name="091c" id="091c" class="graf graf--figure graf-after--h4"><img class="graf-image" data-image-id="1*0zHSDA50OX347DKfxQjfdQ.png" data-width="931" data-height="539" src="https://cdn-images-1.medium.com/max/800/1*0zHSDA50OX347DKfxQjfdQ.png"></figure><p name="f54f" id="f54f" class="graf graf--p graf-after--figure">We will send one of the GET requests to the sent to repeater , then :</p><figure name="bdb1" id="bdb1" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*YtqLiqE8ORhmV7KxDKmYMg.png" data-width="1605" data-height="846" src="https://cdn-images-1.medium.com/max/800/1*YtqLiqE8ORhmV7KxDKmYMg.png"><figcaption class="imageCaption">Congratulations, you solved the lab!</figcaption></figure><p name="facb" id="facb" class="graf graf--p graf-after--figure">We will move to the Repeater tab, then you will change the productId number to /product?productId=”Abdelwahab_Shandy”<br>Then you will send the request<br>You will find that the answer is as follows:<br>You will find the error message and what you need to prove in this tab .</p><blockquote name="7d42" id="7d42" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">See you soon in other reports….!!</em></strong></blockquote><blockquote name="2c91" id="2c91" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">Abdelwahab_Shandy</em></strong></blockquote><blockquote name="06a9" id="06a9" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">AS_Cyber</em></strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/1c27d3588953"><time class="dt-published" datetime="2024-04-26T15:12:32.707Z">April 26, 2024</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/lab-information-disclosure-in-error-messages-1c27d3588953" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>