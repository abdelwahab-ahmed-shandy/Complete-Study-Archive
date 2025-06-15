## 🍪 إدارة الكوكيز 🛡️ ومعالجة الجلسات

---

### ⚠️ لماذا نحتاجها؟

- لأن HTTP بروتوكول **بدون حالة (Stateless)**، نحتاج إلى وسائل لتعقب المستخدمين وتوفير المصادقة.
- يتم ذلك عبر:
  - **Cookies (الكوكيز)**
  - **Sessions (الجلسات)**
  - **JWT (رموز الويب JSON)**

---

## 🔐 الجلسة (Session)

- الجلسة هي **اتصال مؤقت** بين المستخدم والخادم يُنشأ عند تسجيل الدخول أو بدء التفاعل.
- تُستخدم لتعقب **نشاطات المستخدم** وحالته أثناء الاستخدام.

### 🧩 خصائص الجلسة

- **معرّف فريد (Session ID):**
  - لكل جلسة معرف فريد.

- **الأمان:**
  - حماية معرف الجلسة من التسريب أو السرقة.
  - تشفير الكوكيز.
  - تفعيل خيارات `HttpOnly`, `Secure`.

- **انتهاء المهلة:**
  - إنهاء الجلسة تلقائيًا بعد فترة من الخمول (Idle Timeout).

- **الربط بالمستخدم:**
  - التأكد من أن الجلسة تخص نفس المستخدم المسجّل.

- **إعادة المصادقة:**
  - طلب إعادة إدخال كلمة المرور في العمليات الحساسة.

- **مكافحة تثبيت الجلسة:**
  - تحديث معرف الجلسة بعد تسجيل الدخول.

---

## 🍪 الكوكيز (Cookies)

- الكوكيز هي ملفات صغيرة يخزنها المتصفح على جهاز المستخدم.
- تُستخدم لتخزين:
  - معلومات الجلسة
  - التفضيلات
  - تتبع المستخدم

### 📂 أنواع الكوكيز

- **كوكيز الجلسة**
  - تُحذف عند إغلاق المتصفح.
  - تُستخدم خلال نفس الزيارة.

- **كوكيز دائمة**
  - تبقى لفترة محددة أو حتى الحذف اليدوي.
  - تُستخدم في تسجيل الدخول التلقائي أو حفظ التفضيلات.

### 🔒 خصائص الأمان في الكوكيز

- `HttpOnly`: تمنع الوصول للكوكيز عبر JavaScript (ضد XSS).
- `Secure`: تُرسل فقط عبر اتصال HTTPS.
- `SameSite`: تمنع هجمات CSRF.

---

## 🤝 كيف تعمل الجلسات مع الكوكيز

- الجلسة تُخزن على الخادم.
- يُخزن معرف الجلسة فقط في الكوكيز على المتصفح.
- عند كل طلب، يرسل المتصفح معرف الجلسة ليُسترجع المستخدم.

### ✅ هذا النظام:

- يُبقي **البيانات الحساسة على الخادم**.
- الكوكيز تحتوي فقط على مرجع (معرّف الجلسة).
- أكثر أمانًا من تخزين كل البيانات في الكوكيز.

---

## 🔐 JWT – رمز الويب JSON

### 📦 هيكل JWT

1. **Header (الرأس)**
   - يحتوي على نوع الرمز (عادة "JWT") وخوارزمية التوقيع مثل `HS256`.

2. **Payload (الحمولة)**
   - يحتوي على البيانات أو الادعاءات (Claims) مثل `sub`, `exp`.
   - **غير مشفرة** لكن **موقعة** لضمان عدم التلاعب بها.

3. **Signature (التوقيع)**
   - ناتج توقيع الرأس والحمولة بمفتاح سري أو خاص.
   - يضمن أن الرمز لم يتم تغييره.

> التركيب:  
> `Header.Payload.Signature`

---

### 🧪 التحقق من صحة JWT

- يتم التحقق من أن التوقيع صحيح ولم يتم التلاعب بالبيانات.
- إذا تطابق التوقيع مع المفتاح المعروف → يتم قبول الرمز.  
- إذا لم يتطابق → يتم رفض الرمز.


---
---
---

## 🍪 Cookies Management & 🛡️ Session Handling

---

### ⚠️ Why It's Needed

- Since HTTP is a **stateless protocol**, we need mechanisms to track users and provide authentication.
- This can be done using:
  - **Cookies**
  - **Sessions**
  - **JWT (JSON Web Tokens)**

---

## 🔐 Session

- A session is a **temporary connection** between the user and the server, created at login or on first interaction.
- It is used to track user **activities**, **states**, and **authentication** during usage.

### 🧩 Session Characteristics

- **Unique Identifier:**
  - Each session has a unique Session ID (SID).

- **Security:**
  - Protect session ID from leakage or theft.
  - Use **cookies encryption**.
  - Enable flags like `HttpOnly`, `Secure`.

- **Timeout:**
  - End session automatically after a period of inactivity (Idle Timeout).

- **User Binding:**
  - Ensure the session is only used by the authenticated user.

- **Re-authentication:**
  - Prompt the user to re-enter password for sensitive operations.

- **Anti-Session Fixation:**
  - Regenerate session ID after login.

---

## 🍪 Cookies

- Cookies are small files stored on the user's device by the browser.
- They store:
  - Session information
  - User preferences
  - Tracking data

### 📂 Types of Cookies

- **Session Cookies**
  - Deleted when the browser closes.
  - Used to track session during a single visit.

- **Persistent Cookies**
  - Stored for a longer time (expiration or manual delete).
  - Used for “remember me” or saved preferences.

### 🔒 Secure Cookie Properties

- `HttpOnly`: Prevents access via JavaScript to reduce XSS attacks.
- `Secure`: Sent only over HTTPS.
- `SameSite`: Prevents Cross-Site Request Forgery (CSRF).

---

## 🤝 Session + Cookies Workflow

- A session is stored server-side.
- The browser stores only the **session ID** in a cookie.
- The server retrieves session data based on that ID.

### ✅ This Approach:

- Keeps **sensitive data on the server**.
- Only a reference (SID) is stored on the client.
- More secure than storing everything in cookies.

---

## 🔐 JWT (JSON Web Token)

### 📦 JWT Structure

1. **Header**
   - Contains type (`JWT`) and signing algorithm (e.g., `HS256`, `RS256`).
	```json
{
  "alg": "HS256",
  "typ": "JWT"
}

2. **Payload**
   - Contains **claims** (user info and metadata).
   - Common claims: `sub`, `exp`.

{
  "sub": "1234567890",
  "name": "George White",
  "admin": true,
  "iat": 1516239022
}



3. **Signature**
   - Ensures integrity of the token.
   - Signed using secret/private key.

Base64UrlEncode(header) + "." + Base64UrlEncode(payload)
→ Signed with HMACSHA256 using a secret key.


> The structure:  
> `Header.Payload.Signature`

---

### 🧪 JWT Validation

- Validates that the token was **not tampered with**.
- Compares signature with known secret or public key.
- If valid → Accept the token  
  If not → Reject the token

---

### By Abdelwahab Shandy 