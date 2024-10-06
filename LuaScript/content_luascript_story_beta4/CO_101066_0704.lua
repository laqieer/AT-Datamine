-- このluaスクリプトは、CO_101066_0704.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera002 = SetTemplate("Actor002",85,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ブレイズ★★:ワシの仮説が正しければ<br>バルバロイが喰らった記憶の行先は――
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020031")


	--★★ブレイズ★★:そしてオブリヴィエの果ては――<br>つまり、失われた記憶を――
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020032")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0034")
-- ▲直接出力

	--★★ブレイズ★★:むむむ…<br>しかし、今のままでは決め手に欠ける…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020034")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力

	--★★ブレイズ★★:研究を急がなければ…<br>自らの存在をかけて戦う若者たちのために――
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020035")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力

	--★★ノワール★★:先生
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020037")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ノワール★★:（全然気づかないな…<br>よっぽど集中しているみたいだ）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101066_07020039")

	open_select_window_tag(Actor001,"Normal","CO_101066_07020041","CO_101066_07020042")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	open_cutin(1,2)
	on_cutin(1,Actor001,"Anger")
	change_face(Actor001,"Anger")

	--★★ノワール★★:ブレイズ先生！！！！！！！！！！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","CO_101066_07020044")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0030")
-- ▲直接出力
	close_cutin()
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:うひゃああ！！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020045")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-100,0.3)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:って、なんじゃノワールか。驚かせるでない…<br>鼓膜が破れるかと思ったぞい…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020046")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:やっと気づいてくれたみたいだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020047")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Surp")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ブレイズ先生！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020049")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-100,0.3)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0007")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:おお、ノワール！びっくりしたぁ<br>いきなり肩を叩くでない！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020051")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:何度も声をかけたって！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020052")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0037")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:すまんすまん、集中しておったもんでな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020053")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:まったく…で、どうしたんじゃ<br>そんなにワシと話がしたかったのか？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020055")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたがずいぶん根を詰めてるって聞いて<br>様子を見に来たんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020056")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0007")
-- ▲直接出力

	--★★ブレイズ★★:ほう。もしや、マーリンになにか言われたか？<br>あの子も心配性じゃのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020057")

	open_select_window_tag(Actor001,"Normal","CO_101066_07020059","CO_101066_07020060")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:弟子が師匠のことを心配するのは当然だろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020062")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0008")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:…そうじゃなあ<br>あの子は昔からよく気がつく子じゃった
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020063")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:気がついてるのになにもできんというのも<br>もどかしいじゃろうなあ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020064")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんの話だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020065")

-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:…いや。こっちの話じゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020066")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:マーリンさんだけじゃない<br>俺だって心配してる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020068")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0001")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:おぬし…意外と情に厚いタイプなんじゃな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020069")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0048")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:い、いいだろ俺のことはどうでも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020070")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0015")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:どうでもよくはない
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020071")

	change_face(Actor002,"Sad")

	--★★ブレイズ★★:おぬしがいい子であればあるほど<br>胸が痛むかもしれんな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020072")

	goto Block2end

::Block2end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:悪いが、今ちょっと手が離せないんじゃ<br>来る『淘汰』に備え、ワシは急がねばならん
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020074")

	change_face(Actor001,"Normal")

	--★★ノワール★★:淘汰…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020075")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0028")
-- ▲直接出力

	--★★ブレイズ★★:授業でやらんかったか？<br>世界にバルバロイが大量発生する現象のことじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020076")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ブレイズ★★:人間の世界とバルバロイの世界とが繋がり<br>いずこかからバルバロイが大挙して押し寄せる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020077")


	--★★ブレイズ★★:まさにこの世の終わり。それが『淘汰』じゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020078")

	change_face(Actor001,"Sad")

	--★★ノワール★★:そんなの本当に起こるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020079")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:『淘汰』は確実に起こる。それは間違いない<br>だからこそ研究を急がねばならんのじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020080")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:確実にって、なにを根拠に…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020081")

	change_face(Actor002,"Sad")

	--★★ブレイズ★★:………
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020082")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
voice_play("VO_101066_sp_0001_1")
-- ▲直接出力

	--★★ブレイズ★★:…すまんが、今日は帰ってもらえるかのう<br>もうちょっとで研究がまとまりそうなんじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020084")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0038")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_07020085")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0037")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:すまんな<br>マーリンには上手いこと言っておいてくれ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_07020086")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ブレイズ_ランクアップ7_5")
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
	load_area_scene_preload(110151)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
