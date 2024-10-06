-- このluaスクリプトは、CO_101064_0503.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_02","110101_02_h")
Include("content_adv_advsmall_110101_02","Template110101_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_02,CameraPos110101_02_001)
	InitializeTemplateRandomCamera110101_02()
	InitializeTemplate110101_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ノワール★★:ふう、今日も疲れたな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05030002")

	change_face(Actor001,"Normal")

	--★★ノワール★★:リアムさんに教わったやりかたで<br>ハーブの世話をしてから寝るか…ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05030003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:こ、これ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05030004")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ハーブに蕾がついてる！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05030005")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05030007")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え、えっとえっとえっと…<br>このあとどうすればいいんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05030008")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ヘタなことしたら<br>せっかくの蕾が枯れちゃうよな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05030009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:あとでリアムさんかクラリスに<br>詳しく話を聞きに行かなくちゃ…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05030010")

-- ▼直接出力
local trustParam = set_communication_rankup("リアム_コミュランク", "リアム_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName110101_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
