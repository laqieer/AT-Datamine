-- このluaスクリプトは、EA_053_045.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_02","110111_02_h")
Include("content_adv_advsmall_110111_02","Template110111_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110111_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110111_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_004)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110111_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_006)
	InitializeTemplateRandomCamera110111_02()
	InitializeTemplate110111_02()
-- ▼直接出力
turn_lookat(Actor008,Actor007,0)
turn_lookat(Actor009,Actor006,0)
turn_lookat(Actor001,Actor007,0)
turn_lookat(Actor004,Actor006,0)
turn_lookat(Actor005,Actor004,0)
turn_lookat(Actor007,Actor001,0)
turn_lookat(Actor006,Actor001,0)
Hide(Actor008)
Hide(Actor009)
set_enable_auto_lookat(Actor004,false)
set_enable_auto_lookat(Actor005,false)
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
turn_lookat(Actor002,Actor007,0)
turn_lookat(Actor003,Actor006,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115120)
	Actor001 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401014","001","401014001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor009")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★男子生徒★★:当日はお菓子が配られるらしいよ<br>楽しみだな～
	Talk(Actor001,"NPCNAME_0001","speech","N","EA_053_0450002")

	PlayAction(Actor004,"to  Std_Talk")

	--★★女性A★★:チラシ見てからワクワクが止まらないの<br>あ～、早く食べたい五月祭スイーツ
	Talk(Actor004,"NPCNAME_0183","speech","N","EA_053_0450003")

	PlayAction(Actor006,"to  Std_Talk")

	--★★子供A★★:あのね！五月祭がはじまったら<br>僕、１番にお菓子をもらいにいくんだ！
	Talk(Actor006,"NPCNAME_0140","speech","N","EA_053_0450006")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★女性B★★:
	Talk(Actor005,"NPCNAME_0184","speech","N","EA_053_0450007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0450009")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:すごいな<br>皆、お菓子の話で持ち切りだ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0450010")

	open_select_window_tag(Actor002,"Normal","EA_053_0450012","EA_053_0450013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:リオネスのチラシ効果かな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0450016")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ノワール★★:確かに<br>頑張って宣伝してたみたいだしな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0450017")

	change_face(Actor003,"Laugh")

	--★★ノワール★★:おかげで、皆がすごく期待してる
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0450018")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:………
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0450019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:無料ってのがいいのかな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0450022")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Laugh")

	--★★ノワール★★:それもあるけど…<br>でも、それだけじゃないんじゃないかな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0450023")

	change_face(Actor003,"Smile")

	--★★ノワール★★:食堂のご飯が美味しいのは皆が知ってることだし<br>その分、お菓子への期待値も高いのかも
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0450024")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:………
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0450025")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:俺たちが作ったお菓子を待ってる人がこんなに…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0450027")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
setup_small_camera_start()
PlayActionDirect(Actor006,"to Wlk")
turn_lookat(Actor006,Actor002,0.4)
wait_time(0.3)
PlayActionDirect(Actor007,"to Wlk")
turn_lookat(Actor007,Actor002,0.4)
wait_time(0.1)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.3)
PlayActionDirect(Actor007,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Joy")
-- ▼直接出力
PlayActionDirect(Actor007,"to  Std_Joy")
-- ▲直接出力

	--★★子供A★★:
	Talk(Actor006,"NPCNAME_0140","speech","N","EA_053_0450028")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor007,"to Std_Loop")
PlayActionDirect(Actor001,"to Wlk")
wait_time(0.1)
turn_lookat(Actor001,Actor002,0.8)
wait_time(0.5)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat(Actor004,Actor002,0.8)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor005,"to Wlk")
turn_lookat(Actor005,Actor002,0.5)
wait_time(0.5)
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0038")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:お、どうした。ふたりとも
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0450030")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(1.0)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{9.284, -0.003, -5.642},5)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{8.302, -0.003, -5.382},5)
wait_time(0.6)
show_image("101010140",0.0,0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
Hide(Actor002)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor001)
wait_time(0.2)
Appear(Actor008)
Appear(Actor009)
wait_time(1.6)
hide_image(BLACK_WHITE_TIME)
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")

	--★★子供A★★:ねぇ、ガウェイン…<br>お菓子作りが間に合わないってほんと？
	Talk(Actor006,"NPCNAME_0140","speech","N","EA_053_0450031")

	change_face(Actor008,"Surprise")

	--★★ガウェイン2★★:！！
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","EA_053_0450032")

	PlayAction(Actor007,"to  Std_Angry")

	--★★子供B★★:大丈夫だよね？<br>五月祭のお菓子、配るのやめたりしないよね？
	Talk(Actor007,"NPCNAME_0141","speech","N","EA_053_0450033")

	play_head_motion(Actor008, "No", 0.3, 1.0, false)
	change_face(Actor008,"Sad")

	--★★ガウェイン2★★:えっと、それは――…
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","EA_053_0450034")

	PlayAction(Actor009,"to  Std_Talk")

	--★★ノワール2★★:落ち着いて<br>なんでそんな話になったんだ？
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_053_0450035")


	--★★子供A★★:僕たち、五月祭のお菓子が楽しみ過ぎて…<br>食堂を覗きに行ったんだ
	Talk(Actor006,"NPCNAME_0140","speech","N","EA_053_0450036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")

	--★★子供B★★:そしたら…リオネスが<br>「お菓子が行き渡らないかも」って話してて
	Talk(Actor007,"NPCNAME_0141","speech","N","EA_053_0450037")

	change_face(Actor008,"Normal")

	--★★ガウェイン2★★:…あの話を聞いてたのか
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","EA_053_0450038")


	--★★子供A★★:僕たち、チラシをもらってから<br>ずっと楽しみにしてるんだ
	Talk(Actor006,"NPCNAME_0140","speech","N","EA_053_0450039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Sad02")

	--★★子供A★★:でも、もし数が足りなかったら<br>皆が食べられないかもしれない…
	Talk(Actor006,"NPCNAME_0140","speech","N","EA_053_0450040")

	PlayAction(Actor008,"to  Std_Worry")
	change_face(Actor008,"Sad")

	--★★ガウェイン2★★:…そんなに欲しいか？<br>別にものすごい高級品とかでもないのに
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","EA_053_0450041")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★子供B★★:もちろん！<br>だってさ、ただのお菓子じゃないんだよ
	Talk(Actor007,"NPCNAME_0141","speech","N","EA_053_0450042")


	--★★子供B★★:街の皆のためにって作ってくれた<br>特別なお菓子なんだもん！
	Talk(Actor007,"NPCNAME_0141","speech","N","EA_053_0450043")

	PlayAction(Actor006,"to  Std_Joy")

	--★★子供A★★:五月祭の日限定の特別なお菓子！<br>皆で食べたいじゃん！
	Talk(Actor006,"NPCNAME_0140","speech","N","EA_053_0450044")

	PlayAction(Actor007,"to  Std_Sad02")

	--★★子供B★★:でも、このままじゃ食べられないのかな…
	Talk(Actor007,"NPCNAME_0141","speech","N","EA_053_0450045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガウェイン2★★:………
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","EA_053_0450046")

	PlayAction(Actor009,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★ノワール2★★:大丈夫だよ。なんとかするさ<br>なぁ、ガウェイン
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_053_0450047")

	change_face(Actor008,"Normal")

	--★★ガウェイン2★★:ノワール…
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","EA_053_0450048")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(0.6)
PlayActionDirect(Actor009,"to Wlk")
turn_lookat(Actor009,Actor008,0.4)
wait_time(0.4)
PlayActionDirect(Actor009,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	PlayAction(Actor009,"to  Std_Talk")
	change_face(Actor009,"Laugh")

	--★★ノワール2★★:皆が困ったとき立ち上がるのがヒーロー<br>…だろ？
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_053_0450049")

	change_face(Actor008,"Surprise")

	--★★ガウェイン2★★:…！
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","EA_053_0450050")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
PlayActionDirect(Actor008,"to Wlk")
turn_lookat(Actor008,Actor009,0.4)
wait_time(0.4)
PlayActionDirect(Actor008,"to Std_Loop")
wait_time(0.4)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ガウェイン2★★:…ああ――そうだよな
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","EA_053_0450051")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115120)
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401014","001","401014001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
