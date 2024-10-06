-- このluaスクリプトは、MA_01B111_16.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera002 = SetTemplate("Actor002",-100,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115061)
	Actor001 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("エクセリア", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★エクセリア★★:問題提起と推論の積み重ねばかりで<br>断定的な答えの明示がなかったのがマイナスね
	Talk(Actor001,"CHRNAME_EXCELIA","speech","L","MA_01B111_160002")

-- ▼直接出力
 --PlayPartVoice("ディンドラン", "肯定3")
-- ▲直接出力

	--★★ディンドラン★★:昨日貸りた本を<br>もう返却されるのですか？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B111_160003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★エクセリア★★:本の虫でいたほうが<br>貴方も安心でしょう？
	Talk(Actor001,"CHRNAME_EXCELIA","speech","L","MA_01B111_160004")

-- ▼直接出力
 --PlayPartVoice("ディンドラン", "悩む")
-- ▲直接出力

	--★★ディンドラン★★:当てつけのように読まれる本が<br>可哀想ではありますが
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B111_160006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力

	--★★エクセリア★★:それは失礼<br>ページをめくる手が止まらなかったのは事実よ
	Talk(Actor001,"CHRNAME_EXCELIA","speech","L","MA_01B111_160007")

	change_face(Actor001,"Smile")

	--★★エクセリア★★:大図書院の守り人の<br>推薦図書なだけはあるわ
	Talk(Actor001,"CHRNAME_EXCELIA","speech","L","MA_01B111_160009")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディンドラン★★:…この本、私もあまり好きではないんです<br>資料からの抜粋と長い自論の連なりばかりで
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B111_160011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★エクセリア★★:分厚くて手が疲れるのもマイナスね<br>そのうえカビ臭い
	Talk(Actor001,"CHRNAME_EXCELIA","speech","L","MA_01B111_160012")


	--★★エクセリア★★:果たして推す理由は？
	Talk(Actor001,"CHRNAME_EXCELIA","speech","L","MA_01B111_160013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:読破出来た方と<br>解釈を語り合うため
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B111_160015")

-- ▼直接出力
 --PlayPartVoice("エクセリア", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★エクセリア★★:斜め読みしていた部分があるわ<br>もう一度目を通す必要がある
	Talk(Actor001,"CHRNAME_EXCELIA","speech","L","MA_01B111_160017")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★エクセリア★★:貸し出しの延長を願える？
	Talk(Actor001,"CHRNAME_EXCELIA","speech","L","MA_01B111_160019")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115061)
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
