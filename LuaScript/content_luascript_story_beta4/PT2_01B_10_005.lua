-- このluaスクリプトは、PT2_01B_10_005.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラグネル★★:あ、ノワールだ<br>聖杯探索お疲れ様！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01B_10_0050002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ラグネルのほうこそお疲れ様<br>近頃、ローマ側の動きはどうなってるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0050003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラグネル★★:そうそう、聞いてよ<br>ローマがね、壁を作ろうとしてるの！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01B_10_0050004")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:壁？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0050005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラグネル★★:キャメリアード城の東に<br>バルバロイを大量に配備して
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01B_10_0050006")


	--★★ラグネル★★:この島を<br>東西に分断しようとしてるんだって
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01B_10_0050007")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:そんなことされたら聖杯探索に支障が…<br>というより、それって現実的に可能なのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0050008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラグネル★★:できるかどうかは<br>あたしにはよくわかんないけど、安心して
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01B_10_0050009")

	change_face(Actor002,"Normal")

	--★★ラグネル★★:もう少ししたらあたしたちが行って<br>バルバロイを追い払ってきてあげる
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01B_10_0050010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:頼もしいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0050011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラグネル★★:ノワールたちは聖杯探索に専念していいよ<br>今回、ガウェインの気合の入りかたが違うから！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01B_10_0050012")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ガウェインが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0050013")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラグネル★★:どうやら向こうで指揮を執ってるのが<br>ヴェルナルス先せ…大将軍らしいんだよね
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01B_10_0050014")

	change_face(Actor002,"Normal")

	--★★ラグネル★★:ガウェイン<br>大将軍をやっつけて話をしたいんだって
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01B_10_0050015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラグネル★★:…あたしも、だけどね
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01B_10_0050016")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ふたりがヴェルナルス大将軍と<br>話したいことってなんなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0050017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:それは…<br>時期を見て話すから、今はゴメン
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01B_10_0050018")

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
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
