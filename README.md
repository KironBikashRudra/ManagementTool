# ManagementTool

ManagementTool は c# の色々ことを勉強するため個人目的のプロジェクトです。

## Unit テスト：
Unit テストではプログラムで API や、関数を呼び出して、指定した結果と返した結果を合わせてテスト出来ます。

## 含まれているの実装：

### 自動テストフレームワーク：
- NUnit テストフレームワーク

### プロジェクト紹介：
- ManagementTool : テスト用のプロジェクト
- NUnitTests : テストするのプロジェクト。nUnit フレームワークを使っています。

> ** MSTest フレームワークは NUnit.Net フレームワークと似ていますが、MSTest は .Net Framework で作っているプロジェクトを unit テストするためフレームワークです。一方、NUnitは.net coreアプリケーションの unit テストフレームワークです。

### テスト機能：
**DB 接続テスト機能**
> DB 接続が成功かどうかテスト
- TestOpenConnection()
> DB 接続が成功nにクローズできるかどうかテスト
- TestCloseConnection()
  
  
**ManagementTool の機能をテスト機能**
> Adminが更新できているか
- CanBeEditedBy_Admin_True()
> マネジャーが更新できるかどうか
- CanBeEditedBy_Manager_False()
> ログインユーザーが更新できるかどうか
- CanBeEditedBy_Me_True()
  

**実際の API テスト機能**
>  Api リクエストテスト
- TestAPIRequest_SearchBooks_OK()

### テスト方法：
VS オプションバー ＞ テスト ＞ 全テスト実行


### テスト結果：
テストが成功場合：
![image](https://github.com/KironBikashRudra/ManagementTool/assets/88172726/df1631d9-20b1-4755-9227-2ea7d38faa8e)

テストが失敗した場合：
![image](https://github.com/KironBikashRudra/ManagementTool/assets/88172726/d7b1d4df-d862-4eac-8abf-b86cae782ff4)




