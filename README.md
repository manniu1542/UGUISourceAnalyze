# UGUISourceAnalyze


#配置项目

1. 使用Unity的版本2018.4.30f1  
2. Unity删除UI包 Window =>   Pakage Manager=> 移除ui相关的包
3. Unity编辑器目录中 删除 掉 GUISystem 。路径 
 2018.4.30f1\Editor\Data\UnityExtensions\Unity\GUISystem
4. 添加 从Github中的 https://github.com/Unity-Technologies/uGUI 找一个 2018.4.30f1 版本可兼容的 UGUI 源码  分支。 放入项目文件中。（删除掉vs项目的 配置文件 例如：lib，proptys 等。）