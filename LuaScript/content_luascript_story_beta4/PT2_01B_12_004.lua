-- このluaスクリプトは、PT2_01B_12_004.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:エクセリア、リリアーナ<br>ふたりに話しておきたいことがある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0040002")

-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:なにかしら？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT2_01B_12_0040003")


	--★★ノワール★★:俺たちは４日後に<br>コルベニック城に攻め入る
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("エクセリア", "悩む")
-- ▲直接出力

	--★★エクセリア★★:どうしてそれを私たちに話すの？<br>人質交換にでも使うつもり？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT2_01B_12_0040005")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:そんなつもりはないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0040006")

-- ▼直接出力
PlayPartVoice("エクセリア", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エクセリア★★:私は銀卓騎士団の軍師であり<br>二の脚のキラーズよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT2_01B_12_0040007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★エクセリア★★:マスターや仲間に危害が及ぶとわかった以上<br>刺し違えてでもここであなたを止めるわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT2_01B_12_0040008")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:いや<br>キミがそんなことをしないのはわかってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0040009")

-- ▼直接出力
PlayPartVoice("エクセリア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:…どういうつもりなの？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT2_01B_12_0040010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:俺にはキミたちが<br>マスターの現状を受け入れているとは思えない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0040011")


	--★★ノワール★★:キミたちを自由にすることはできないけど<br>黙ってマスターと戦うのは卑怯な気がした
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0040012")

	change_face(Actor002,"Sad")

	--★★エクセリア★★:………
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT2_01B_12_0040013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力

	--★★リリアーナ★★:あの…スノードン山で会ったときの<br>ペレス王の様子はどう…でしたか？
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","PT2_01B_12_0040014")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:バルバロイによる浸食がかなり進んで<br>既に自我を失っているように見えた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0040015")

-- ▼直接出力
PlayPartVoice("リリアーナ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★リリアーナ★★:そう…ですか
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","PT2_01B_12_0040016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:じゃ、俺はこれで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0040017")

-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:軍師として忠告するわ<br>ノワール、あなたは甘すぎる
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT2_01B_12_0040018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:でも…今はお礼を言っておくわ<br>ありがとう
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT2_01B_12_0040019")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
