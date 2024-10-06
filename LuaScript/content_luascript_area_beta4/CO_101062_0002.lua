-- このluaスクリプトは、CO_101062_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114071_01","114071_01_h")
Include("content_adv_advsmall_114071_01","Template114071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114071_01,CameraPos114071_01_004)
	Camera002 = SetTemplate("Actor002",115,CharaPos114071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName114071_01,CameraPos114071_01_003)
	InitializeTemplateRandomCamera114071_01()
	InitializeTemplate114071_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:いや～、いい湯でしたね！日頃の疲れが吹っ飛びます～
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:わかる大きい風呂で手足を伸ばせるの、最高だよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ログレスにもこういう場所があればいいんだけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "納得")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:確かに！…あ、これってビジネスチャンスかも？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010011")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:おいおいこれ以上商売の幅を広げる気か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010012")

-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:あはは！冗談ですよ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★マルイル★★:今はまだ、ログレスのお店を大きくすることに集中したいんです。今はまだ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010014")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今はまだ、ね…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "気合い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:さてさて…お風呂上りといえばなにいっちゃいます？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010016")

	open_select_window_tag(Actor001,"Normal","CO_101062_00010017","CO_101062_00010018","CO_101062_00010019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:やっぱり牛乳だろ腰に手を当ててぐいっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:ですよね～！お風呂上がりの牛乳ってなんであんなに美味しいんでしょう
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:ぼくも、行商の帰りにここに来たときはいつも牛乳を飲んでますよ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010023")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:キンキンに冷えた牛乳が身体にスーッと浸透する感じ、たまらないですよね～
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:骨が丈夫になりそうだ…だから足腰が強いのかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ここはやっぱり、ビールだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010028")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:おっ、いいですね～！キンキンに冷えたビールをグイっと…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("マルイル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:………って、駄目ですよ！ノワールさんは未成年でしょ！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:引っ掛からなかったか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010031")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("マルイル", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:それにぼく、こういうところであんまりお酒を売ってもらえないんですよ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルイル★★:「子供にお酒は売れません！」って失礼な話ですよねぇ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010033")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（マルイル、童顔だもんな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101062_00010034")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:水でいいんじゃないか？タダだし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010037")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:おお…ノワールさん、倹約家ですね…！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ログレスで暮らしてるとついついいろいろ買っちゃってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010039")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタン…妹によく怒られるんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010040")

	change_face(Actor001,"Normal")

	--★★ノワール★★:だから最近はあまり羽目を外さないように心がけてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★マルイル★★:なるほど…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010042")

-- ▼直接出力
PlayPartVoice("マルイル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:ぼくとしては、財布のひもは<br>適度に緩めていただけると嬉しいですけど…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★マルイル★★:でも、ノワールさんの言うように倹約も大事だと思いますよ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010044")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:商売人がそんなこと言っていいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010045")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:だって、すっからかんになられたらぼくのお店で買い物してもらえませんもん！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_00010046")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…それが本音か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_00010047")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"マルイル")
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
	load_area_scene_preload(114071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
