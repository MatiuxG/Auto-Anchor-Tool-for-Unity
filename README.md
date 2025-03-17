# 🎯 Auto Anchor Tool for Unity  

A Unity Editor tool that automatically adjusts UI anchors based on an element's current position. This helps maintain UI consistency across different screen sizes and resolutions.  

## 📦 Package Information  
- **Name:** `MatiuxG.AutoAnchorTool`  
- **Version:** `1.0.0`  
- **Unity Compatibility:** `2021.3+`  
- **Category:** UI / Tools  
- **Author:** Your Name  
- **Repository:** [GitHub Repo](https://github.com/MatiuxG/AutoAnchorTool)  

---

## 🚀 Features  
✅ Automatically adjusts UI **anchors** based on the current position of the selected elements.  
✅ Supports **multiple selections** for batch processing.  
✅ Works within the Unity **Editor Window**.  
✅ Avoids **manual adjustments**, saving time in UI design.  
✅ Easy to install via Unity **Package Manager (UPM)**.  

---

## 📥 Installation  

### **🔹 1. Install via Git (Recommended)**
1. Open Unity and go to **Window > Package Manager**.  
2. Click **+ > Add package from Git URL**.  
3. Enter the repository URL: https://github.com/MatiuxG/AutoAnchorTool.git
4. Click **Add** and wait for the package to install.  

### **🔹 2. Manual Installation**
1. Download the repository as a **ZIP** file.  
2. Extract it into your Unity project's `Packages/` folder.  
3. Open Unity and ensure it appears in **Package Manager**.  

---

## 🛠 Usage  

### **🔹 Method 1: Adjust Anchors from the Context Menu**  
1. **Select** a UI element (must have a `RectTransform`).  
2. **Right-click** in the **Inspector**.  
3. Go to `Adjust Anchors to Position`.  
4. The anchors will **automatically** adjust to fit the element's position.  

### **🔹 Method 2: Adjust Anchors for Multiple UI Elements**  
1. **Select multiple UI elements** in the Hierarchy.  
2. Open **Unity Editor Menu > Tools > Adjust Anchors for Selected UI Elements**.  
3. The tool will process all selected elements and set their anchors.  

---

## 🛑 Limitations  
⚠️ Only works for UI elements with a `RectTransform`.  
⚠️ The selected objects **must be inside a Canvas**.  
⚠️ The parent of the UI element must also have a `RectTransform`.  

---

## 🔧 Development  
### **🔹 Requirements**
- Unity **2021.3+** (May work on earlier versions, but not tested).  
- A basic understanding of **Unity UI** and `RectTransform`.  

### **🔹 How to Contribute**
1. Fork the repository.  
2. Create a new branch (`git checkout -b feature-name`).  
3. Commit your changes (`git commit -m "Added new feature"`).  
4. Push to GitHub (`git push origin feature-name`).  
5. Create a **Pull Request**.  

---

## 📄 License  
This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.  

---

## 📩 Support  
For issues or suggestions, feel free to open an **issue** on GitHub or contact:  
📧 **mateogalvisgamedev@gmail.com**  
📌 [GitHub Issues](https://github.com/MatiuxG/AutoAnchorTool/issues)  

---

🎮 **Happy Coding! 🚀**

