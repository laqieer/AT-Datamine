-- このluaスクリプトは、CO_101013_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112041_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_002)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
keep_ik_lookat(Actor003,Actor001, "J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:あれ？ししょ…ヴェルナルス先生？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05020002")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:お前たちか今日はこんなところにどうした？
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05020003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ちょっと買いたいものがあるんだけど小遣いが足りなくてさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガウェイン★★:キッスさんに働き口を紹介してもらおうと思って来たんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05020005")

-- ▼直接出力
PlayPartVoice("ヴェルナルス", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ヴェルナルス★★:買いたいもの…？
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05020006")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:街で知り合った子供にさ蝶の入った琥珀をプレゼントしたいんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05020007")


	--★★ヴェルナルス★★:ほう？
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05020008")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ノワール★★:ということなんだけどなにかいい仕事ないかな、キッスさん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05020009")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★キッス★★:それならちょうどいいのがあるわよ
	Talk(Actor005,"CHRNAME_KISS","speech","L","CO_101013_05020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★キッス★★:今、まさにヴェルナルス将軍から依頼を受けたところなんだけど
	Talk(Actor005,"CHRNAME_KISS","speech","L","CO_101013_05020011")


	--★★キッス★★:ロンディニウムまで急ぎで届けてほしい書状があるのよ
	Talk(Actor005,"CHRNAME_KISS","speech","L","CO_101013_05020012")

-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ヴェルナルス★★:大きな戦いの準備で忙しくてな私も部下もここから離れることができない
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ヴェルナルス★★:そこでキッス殿に手の空いている傭兵などはいないか相談していた
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05020014")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:道中、たとえバルバロイが出たとしてもみんななら心配もないし…どうかしら？
	Talk(Actor005,"CHRNAME_KISS","speech","L","CO_101013_05020015")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "笑い")
-- ▲直接出力

	--★★ヴェルナルス★★:お前たちなら私も安心して任せられるどうだろうか
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05020016")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:ヴェルナルス先生の頼みとあっちゃ断るわけにはいかねーよな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05020017")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:だね！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05020018")

	open_select_window_tag(Actor001,"Normal","CO_101013_05020020","CO_101013_05020021")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:その手の仕事なら俺たちの得意とするところだ任せてください
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05020023")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★キッス★★:そう言ってくれると思ってたわさすがはラビットちゃんたち♪
	Talk(Actor005,"CHRNAME_KISS","speech","L","CO_101013_05020024")

-- ▼直接出力
PlayPartVoice("ヴェルナルス", "納得")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ヴェルナルス★★:すまないだが、くれぐれも無理はしないようにな
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05020025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:えっと…依頼を受けるのはいいんですが報酬はどのくらい貰えます？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05020027")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:ノ、ノワール！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05020028")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:俺もそれは気になったけど今は聞く空気じゃなくねーか…？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05020029")

-- ▼直接出力
PlayPartVoice("ヴェルナルス", "悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ヴェルナルス★★:急な話だったゆえそれほどの額は準備できないかもしれんが
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05020030")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ヴェルナルス★★:話に挙がった琥珀を買えるくらいは支払うつもりだ
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05020031")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:マジかよ！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05020032")

-- ▼直接出力
PlayPartVoice("ラグネル", "納得")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:さすがはローマ…！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05020033")

	goto Block1end

::Block1end::
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ヴェルナルス★★:これがその書状だ
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05020035")


	--★★ヴェルナルス★★:ローマ本国へ送るものでな船の時間が近い。なるべく急いでもらえるか
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05020036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかりましたさっそく出発します
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05020037")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ5_3")
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
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
