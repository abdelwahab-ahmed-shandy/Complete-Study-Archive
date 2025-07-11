# 🔥 **الباب الثامن : الجدار الناري في Windows (Windows Firewall)**

> الجدار الناري (Firewall) هو خط الدفاع الأول في النظام، وظيفته الأساسية هي **السماح أو حظر الاتصالات** حسب قواعد يتم ضبطها.
>  ---
#### 🧱 **أولًا: ما هو Windows Firewall؟**

- مكون أساسي في Windows.

- يتحكم في حركة المرور الواردة (Inbound) والصادرة (Outbound).

- يعمل عبر "Rules" = قواعد تحدد من/إلى من يتم السماح أو الحظر.
---
#### 🎯 **ثانيًا: وظائف الجدار الناري**

|الوظيفة|الشرح|
|---|---|
|🔒 منع البرامج من الاتصال|منع تطبيق معين من إرسال أو استقبال بيانات|
|✅ السماح ببرامج محددة فقط|كالسماح لـ RDP أو SSH فقط|
|📊 منع بروتوكولات معينة|مثل UDP أو TCP أو بورتات مثل 21, 80, 443|
|📡 حماية ضد التهديدات القادمة من الشبكة|مثل Port Scanning, Unauthorized Access|

---
#### 🛠️ **ثالثًا: طرق فتح الجدار الناري والتحكم به**

|الطريقة|الاستخدام|
|---|---|
|**Control Panel**|واجهة رسومية بسيطة|
|**`wf.msc`**|وحدة التحكم المتقدمة في الجدار الناري|
|**PowerShell**|تحكم كامل وسريع – يُستخدم في الأتمتة والتحليل|

---

#### 📁 **رابعًا: مكونات القاعدة (Firewall Rule)**

|العنصر|مثال|
|---|---|
|🔤 اسم القاعدة|"Block Chrome Internet"|
|📍 الاتجاه|Inbound أو Outbound|
|🌐 البروتوكول|TCP / UDP / Any|
|🔌 رقم المنفذ (Port)|مثل: 80, 443, 3389|
|📦 اسم البرنامج|C:\Program Files\chrome.exe|
|📛 الإجراء|Allow أو Block|

---

#### 🧰 **خامسًا: أوامر PowerShell للتحكم بالجدار الناري**

##### ✅ عرض القواعد الحالية:
```
Get-NetFirewallRule
```

##### ✅ إنشاء قاعدة جديدة للسماح:
```
New-NetFirewallRule -DisplayName "Allow_RDP" -Direction Inbound -Protocol TCP -LocalPort 3389 -Action Allow
```

### ❌ إنشاء قاعدة للحظر:
```
New-NetFirewallRule -DisplayName "Block_FTP" -Direction Outbound -Protocol TCP -RemotePort 21 -Action Block
```

### 🧹 حذف قاعدة:
```
Remove-NetFirewallRule -DisplayName "Block_FTP"
```

##### ✅ تعطيل/تمكين قاعدة:
```
Disable-NetFirewallRule -DisplayName "Allow_RDP"

Enable-NetFirewallRule -DisplayName "Allow_RDP"
```
---
## 🧪 **سادسًا: سيناريوهات أمنية تطبيقية**

|السيناريو|PowerShell Rule|
|---|---|
|حظر برنامج معين من الاتصال بالنت|استخدم المسار الكامل للبرنامج|
```
New-NetFirewallRule -DisplayName "Block Chrome" -Direction Outbound -Program "C:\Program Files\Google\Chrome\Application\chrome.exe" -Action Block
```

| منع أي اتصال صادر إلى بورت 21 (FTP) |
```
New-NetFirewallRule -DisplayName "Block FTP" -Direction Outbound -RemotePort 21 -Protocol TCP -Action Block
```

| السماح فقط للـ RDP الوارد |
```
New-NetFirewallRule -DisplayName "Allow RDP" -Direction Inbound -Protocol TCP -LocalPort 3389 -Action Allow
```
---
## 📊 **سابعًا: المراقبة والتحقق**

##### عرض حالة Firewall:
```
Get-NetFirewallProfile
```

### تحقق من إذا ما كان Firewall مفعلًا:
```
(Get-NetFirewallProfile -Profile Domain).Enabled
```
---
## 🔐 **نصائح أمنية مهمة**

|النصيحة|التفسير|
|---|---|
|لا تترك جميع البورتات مفتوحة|استخدم أقل ما يمكن|
|راقب القواعد المضافة من البرامج|بعض البرامج تضيف قواعد خفية|
|لا تستخدم Allow All بشكل عام|خطر جدًا على النظام|
|احتفظ بنسخة من القواعد الأصلية|Backup للقواعد في ملف باستخدام `Export`|

---

## 📦 **أداة إضافية (GUI): wf.msc**

1. افتح Run → اكتب `wf.msc`
    
2. راقب:
    
    - Inbound Rules
    
    - Outbound Rules

    - القواعد المفعّلة (Enabled)
    
1. أنشئ قاعدة جديدة عبر “New Rule”
    

---
## 📌 ملخص الباب:

|العنصر|المفهوم|
|---|---|
|**Windows Firewall**|جدار حماية للتحكم في الاتصالات|
|**Rules**|قواعد لتحديد ما يُسمح وما يُمنع|
|**wf.msc / PowerShell**|أدوات التحكم|
|**الاتجاه**|Inbound (وارد) / Outbound (صادر)|
|**المجالات الحساسة**|RDP, FTP, HTTP, Custom Ports|













