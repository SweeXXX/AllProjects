HTML:
```html
<!DOCTYPE html>
<html>
<head>
 <title>University Name</title>
 <meta charset="utf-8">
 <meta name="viewport" content="width=device-width, initial-scale=1.0">
 <link rel="stylesheet" href="style.css">
 <script src="app.js"></script>
</head>
<body>
 <header>
  <div class="logo">
   <img src="logo.png" alt="University Name">
  </div>
  <nav>
   <ul>
    <li><a href="#">Home</a></li>
    <li><a href="#">About Us</a></li>
    <li><a href="#">Academics</a></li>
    <li><a href="#">Admissions</a></li>
    <li><a href="#">Student Life</a></li>
    <li><a href="#">Faculty & Staff</a></li>
    <li><a href="#">Alumni</a></li>
    <li><a href="#">News & Events</a></li>
    <li><a href="#">Contact Us</a></li>
   </ul>
  </nav>
  <button class="openSideNav">
   <span></span>
   <span></span>
   <span></span>
  </button>
 </header>
 <main>
  <!-- Main content goes here -->
 </main>
 <footer>
  <p>&copy; University Name | All Rights Reserved</p>
 </footer>
</body>
</html>
```

CSS (style.css):
```css
/* Global styles */
* {
 box-sizing: border-box;
 margin: 0;
 padding: 0;
 font-family: sans-serif;
}
body {
 background-color: #f5f5f5;
 font-size: 16px;
}
a {
 color: #333;
 text-decoration: none;
}
ul {
 list-style: none;
}
header {
 display: flex;
 justify-content: space-between;
 align-items: center;
 padding: 10px;
 background-color: #fff;
 box-shadow: 0px 0px 8px rgba(0,0,0,0.1);
 position: sticky;
 top: 0;
 z-index: 2;
}
.logo {
 flex: 1 0 auto;
}
nav {
 flex: 1 0 auto;
}
nav ul {
 display: flex;
 justify-content: flex-end;
 align-items: center;
}
nav li {
 margin-left: 20px;
}
nav li:last-child {
 margin-right: 0;
}
.openSideNav {
 display: none;
 background-color: transparent;
 border: 0;
 width: 30px;
 height: 30px;
 cursor: pointer;
 margin-top: 10px;
 position: relative;
 z-index: 3;
}
.openSideNav span {
 display: block;
 position: absolute;
 height: 2px;
 width: 100%;
 background-color: #333;
 left: 0;
 right: 0;
 top: 50%;
}
.openSideNav span:nth-child(1) {
 transform: translateY(-7px);
}
.openSideNav span:nth-child(2) {
 transform: translateY(-1px);
}
.openSideNav span:nth-child(3) {
 transform: translateY(5px);
}
@media only screen and (max-width: 768px) {
 /* Styles for mobile and tablet */
 nav {
  display: none;
  width: 100%;
  height: 100vh;
  position: fixed;
  top: 0;
  left: 0;
  z-index: 1;
  background-color: #fff;
  padding: 20px;
  box-shadow: 1px 0px 8px rgba(0,0,0,0.2);
  transform: translateX(-100%);
  transition: transform 0.3s ease-in-out;
 }
 nav ul {
  flex-direction: column;
  align-items: flex-start;
  margin-top: 30px;
 }
 nav li {
  margin: 10px 0;
 }
 .openSideNav {
  display: block;
 }
 .openSideNav span {
  background-color: #333;
 }
 .openSideNav.active span:nth-child(1) {
  transform: rotate(45deg) translate(5px, 5px);
 }
 .openSideNav.active span:nth-child(2) {
  opacity: 0;
 }
 .openSideNav.active span:nth-child(3) {
  transform: rotate(-45deg) translate(5px, -5px);
 }
 nav.active {
  transform: translateX(0);
 }
}