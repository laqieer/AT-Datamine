-- このluaスクリプトは、MA_01A112_34.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",135,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera005 = SetTemplate("Actor005",-85,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera007 = SetTemplate("Actor007",170,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera008 = SetTemplate("Actor008",-65,CharaPos110071_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_008)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_pos(Actor008,{0,0.128,20.8})
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor001,0.7,0.03,0.7,0)
lookat_weight(Actor007,0.6,0.03,0.7,0)
keep_ik_lookat(Actor001,Actor005,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor005,Actor001,"J_Head")
keep_ik_lookat(Actor006,Actor005,"J_Head")
keep_ik_lookat(Actor007,Actor005,"J_Head")
keep_ik_lookat(Actor008,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",125,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",105,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera005 = SetTemplate("Actor005",-140,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera006 = SetTemplate("Actor006",140,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera008 = SetTemplate("Actor008",-110,CharaPos110071_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_008)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
change_face(Actor001,"Normal")
change_face(Actor001,"Normal")
change_face(Actor005,"Normal")
change_face(Actor006,"Normal")
change_face(Actor007,"Normal")
change_face(Actor008,"Normal")
-- ▲直接出力
-- ▼直接出力
lookat_weight_reset(Actor001)
lookat_weight_reset(Actor002)
lookat_weight_reset(Actor003)
lookat_weight_reset(Actor004)
lookat_weight_reset(Actor005)
lookat_weight_reset(Actor006)
lookat_weight_reset(Actor007)
lookat_weight_reset(Actor008)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:裏切りの代償を<br>払わせてやんなきゃね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340002")

-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayActionDirect(Actor006,"to  Std_Joy")
turn_chara(Actor006,170,0.3)
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ラグネル★★:お金持ちだろうからね～え、皇太子殿下<br>すかんぴんにしてやんなきゃあ
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01A112_340003")

-- ▼直接出力
setup_small_camera_start()
change_face(Actor006,"Normal")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ルーシャスの誘いに乗ってローマに行けば<br>姉とともに静かに暮らせていたかもしれない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340004")


	--★★ギネヴィア★★:だけど、遠くに行きたかった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340005")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:自分の日常を裏切って<br>思いもよらない日々が欲しかったとも思ったけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340006")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ギネヴィア★★:今はその平凡が<br>遠くて愛おしいわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A112_340009","MA_01A112_340010","MA_01A112_340011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:失って気づくよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_340013")

	change_face(Actor006,"Sad")

	--★★ラグネル★★:ほんと、懐かしなつかしくって
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01A112_340014")

	PlayAction(Actor007,"to  Std_Talk")
	change_face(Actor007,"Sad")

	--★★ガウェイン★★:けどもうどーしようもねえ<br>先に進むしかねえーのは世知辛ぇよな
	Talk(Actor007,"CHRNAME_GAWAIN","speech","L","MA_01A112_340015")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:進めば進むほど、昔は遠くなるけど<br>それもどーしようもないことよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Talk")
turn_chara(Actor001,165,0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:君キミがルーシャスについていなくてよかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_340018")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,80,0.5)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:案外しつこかったんだよ？<br>ノワールが見てないとこでもね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340019")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:でもわたし、ついてかなかった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:あなたがいたからね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340021")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ノワール★★:ルーシャスは裏切りとも思っていないだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_340023")

	PlayAction(Actor008,"to  Std_No")
-- ▼直接出力
setup_small_camera_start(RndCamera002)
lookat_delay_weight_reset(Actor001,0.3)
lookat_delay_weight_reset(Actor002,0.3)
lookat_delay_weight_reset(Actor006,0.3)
lookat_delay_weight_reset(Actor007,0.3)
-- ▲直接出力
	change_face(Actor008,"Anger")

	--★★マーリン★★:GSの知識を得るべく学園へ入り込んできた…<br>今になって考えれば、迂闊でしたね
	Talk(Actor008,"CHRNAME_MERLIN","speech","L","MA_01A112_340024")

-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
set_enable_auto_lookat(Actor006,true)
set_enable_auto_lookat(Actor007,true)
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★アーサー★★:ルーシャスの語ることが本当であれば<br>ユーサー王はローマとの歴史を消したという
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_340026")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★アーサー★★:我らもローマとの因縁を知らずに<br>ヤツを受け入れてしまった…
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_340027")

-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★アーサー★★:…まあ、ルーシャスの言葉が<br>どこまで信じられるかはわからんがな
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_340028")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(false)
change_face(Actor001,"Normal")
-- ▲直接出力
	goto Block1end

::Block1end::
-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ないものねだりだけど<br>わたし元来貧乏性だから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340030")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:意地汚くても、喰らいつくよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340031")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
template2()
Appear(Actor003)
Appear(Actor004)
setup_small_camera_start(RndCamera004)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor007,"to Greet_one")
	change_face(Actor007,"Smile")

	--★★ガウェイン★★:よォ
	Talk(Actor007,"CHRNAME_GAWAIN","speech","L","MA_01A112_340033")

	PlayAction(Actor004,"to Bow")
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラヴェイン★★:遅参しました
	Talk(Actor004,"CHRNAME_LOVEIN","speech","L","MA_01A112_340034")


	--★★エレイン★★:同席しても？
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340035")

-- ▼直接出力
change_face(Actor007,"Normal")
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A112_340037","MA_01A112_340038","MA_01A112_340039")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:もちろん<br>GSできる騎士は貴重だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_340041")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★ラヴェイン★★:お役に立ってみせますよ。ノワール君
	Talk(Actor004,"CHRNAME_LOVEIN","speech","L","MA_01A112_340042")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
change_face(Actor004,"Normal")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★エレイン★★:席を離れてごめんなさい<br>もう、大丈夫ですから
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340043")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_delay_weight(Actor001,0.7,0.03,0.7,0,0.6)
wait_time(2)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…もういいの？エレイン
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340045")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★エレイン★★:はい。ギネヴィアさん<br>お暇をいただいていましたが
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340046")

-- ▼直接出力
lookat_delay_weight_reset(Actor001,1)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★エレイン★★:あなたのように、なりにきました
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340047")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:みんな待ってたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_340049")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Normal")

	--★★エレイン★★:先輩、私やっぱり<br>諦めきれなくて
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340050")

	change_face(Actor003,"Smile")

	--★★エレイン★★:先輩に、ついていきます
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340051")

	goto Block2end

::Block2end::
-- ▼直接出力
change_face(Actor001,"Normal")
setup_small_camera_start(RndCamera008)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★エレイン★★:思い返していたんです
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340053")


	--★★エレイン★★:私から言葉を引き出してくれた<br>皆さんのことを
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340054")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力

	--★★エレイン★★:勇気を与え続けてくれた<br>ギネヴィアさんのことを
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340055")

	PlayAction(Actor003,"to  Std_Talk")

	--★★エレイン★★:わたしたちの世界を<br>変えようとしてくれている先輩のことを
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340056")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:みんな託され、担い続けている<br>なら…私は誰かの肩を軽くしたい
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340057")

	PlayAction(Actor003,"to  Std_No")

	--★★エレイン★★:キズの癒えない誰かのために
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340058")

	change_face(Actor003,"Anger")

	--★★エレイン★★:隠すものなどなにもありません<br>この命で守れるものがあるのなら
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340059")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")

	--★★エレイン★★:もうキズだらけでも、恥じません
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340060")

	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Normal")

	--★★ラヴェイン★★:傷口を構い過ぎましたね<br>あれこれと
	Talk(Actor004,"CHRNAME_LOVEIN","speech","L","MA_01A112_340062")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ラヴェインがガウェインたちを勇気づけた<br>ギネヴィアはそれを見て勇気を得た
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_340063")


	--★★ノワール★★:つまりはラヴェインがエレインの傷を<br>守ってくれていたんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_340064")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Smile")

	--★★ラヴェイン★★:…買いかぶりが過ぎますよ。ノワール君
	Talk(Actor004,"CHRNAME_LOVEIN","speech","L","MA_01A112_340066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★エレイン★★:ギネヴィアさん
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340067")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:うん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340069")

	PlayAction(Actor003,"to Finger")
	change_face(Actor003,"Smile")

	--★★エレイン★★:敗けませんから
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340071")


	--★★ギネヴィア★★:なんのハナシ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340072")

	PlayAction(Actor003,"to  Std_Worry")

	--★★エレイン★★:なんのハナシでしょう？
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_340073")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:相手になるわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_340075")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
