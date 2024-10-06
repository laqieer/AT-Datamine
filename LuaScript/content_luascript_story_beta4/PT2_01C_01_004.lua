-- このluaスクリプトは、PT2_01C_01_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リアム","挨拶")
-- ▲直接出力

	--★★リアム★★:おはようございます、ノワールさん
	Talk(Actor002,"CHRNAME_LIAM","speech","L","PT2_01C_01_0040002")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ、リアムさん？<br>どうして学生寮にいるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リアム","肯定2")
-- ▲直接出力

	--★★リアム★★:最近、相談のために大聖堂を訪れる生徒が<br>非常に増えていまして
	Talk(Actor002,"CHRNAME_LIAM","speech","L","PT2_01C_01_0040004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:それならばいっそ<br>私が寮に出向くのもよいのではないかと
	Talk(Actor002,"CHRNAME_LIAM","speech","L","PT2_01C_01_0040005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リアム","笑い")
-- ▲直接出力

	--★★リアム★★:なにか相談したいことがあるなら<br>ノワールさんも遠慮なくおっしゃってください
	Talk(Actor002,"CHRNAME_LIAM","speech","L","PT2_01C_01_0040006")

	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0040007")


	--★★リアム★★:………
	Talk(Actor002,"CHRNAME_LIAM","speech","L","PT2_01C_01_0040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リアム","悩む")
-- ▲直接出力

	--★★リアム★★:若木というのは<br>ときに萎れやすく、そして折れやすくもある
	Talk(Actor002,"CHRNAME_LIAM","speech","L","PT2_01C_01_0040009")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リアム★★:ですが活力を取り戻したとき<br>以前よりもはるかに強靭になる
	Talk(Actor002,"CHRNAME_LIAM","speech","L","PT2_01C_01_0040010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リアム★★:私はそれを見守れることを<br>いつも光栄に思っているのです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","PT2_01C_01_0040011")

-- ▼直接出力
PlayPartVoice("ノワール","納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:リアムさんはすごいな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0040012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:今度なにかあったら<br>俺も相談させてもらっていいかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_01_0040013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リアム","肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リアム★★:いつでもどうぞ<br>お待ちしておりますよ
	Talk(Actor002,"CHRNAME_LIAM","speech","L","PT2_01C_01_0040014")

	change_face(Actor002,"Sad")

	--★★リアム★★:（それにしても話の都合上とはいえ<br>我ながら少々年寄りぶり過ぎましたかね…？）
	Talk(Actor002,"CHRNAME_LIAM","mind","L","PT2_01C_01_0040015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
