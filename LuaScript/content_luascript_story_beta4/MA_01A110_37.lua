-- このluaスクリプトは、MA_01A110_37.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_007)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
prop001 = setup_prop_object(10102004)
set_pos(prop001 , {2.381,0.811,-1.91})
set_rot(prop001,{0, 90, 0})
-- ▲直接出力
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,2.381,0.811,-1.91)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001, lookoj,"kara")
lookat_weight(Actor001, {0.8, 0.2, 0.5, 0.5})
keep_delay_ik_lookat_object(Actor001,lookoj,"kara",100)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002, lookoj,"kara")
lookat_weight(Actor002, {0.8, 0.2, 0.5, 0.5})
keep_delay_ik_lookat_object(Actor002,lookoj,"kara",100)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003, lookoj,"kara")
lookat_weight(Actor003, {0.8, 0.2, 0.5, 0.5})
keep_delay_ik_lookat_object(Actor003,lookoj,"kara",100)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor005, lookoj,"kara")
lookat_weight(Actor005, {0.8, 0.2, 0.5, 0.5})
keep_delay_ik_lookat_object(Actor005,lookoj,"kara",100)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★エレイン★★:とても良い題名です
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_370002")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:──『黒装束の後ろ盾』
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_370003")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:文句は受け付けねえぜ<br>ここじゃ脚本・演出・主演が絶対だ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_370004")

-- ▼直接出力
setup_small_camera_start()
lookat_delay_weight_reset(Actor001 , 0.6)
lookat_delay_weight_reset(Actor002 , 0.5)
lookat_delay_weight_reset(Actor003 , 0.4)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:わあ強権
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_370006")

-- ▼直接出力
lookat_delay_weight_reset(Actor005, 0.3)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:王女を救う忠義の騎士の物語…<br>素敵です。とても
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_370007")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★マルディサント★★:まぁわッかりやすいモチーフが目の前にいりゃあ<br>筆も進むってもんよ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01A110_370008")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:わ、わ、わたしと<br>ノワールの関係がモチーフぅ…！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_370010")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定2")
change_face(Actor002,"Normal")
-- ▲直接出力

	--★★ディナタン★★:騎士サマを演じるのはマァル<br>王女サマを演じるのはエレインだけどね
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_370011")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力

	--★★エレイン★★:夢があります…命をかけて会いに来てくれる騎士<br>救いの手を差し伸べてくれる騎士様…
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_370012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor001, {1.0, 0.08, 0.5, 0.3} , 1.0)
keep_ik_lookat(Actor001, Actor005, "J_Head")
lookat_delay_weight(Actor002, {1.0, 0.08, 0.5, 0.3} , 0.5)
keep_ik_lookat(Actor002, Actor005, "J_Head")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★エレイン★★:王女様も<br>決して待っているだけではない
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_370013")

-- ▼直接出力
 --PlayPartVoice("エレイン", "納得")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★エレイン★★:騎士様を叱咤激励し<br>助け、支え合い、共に進む…
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_370014")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:騎士様は王女様の背を支える後ろ盾であり<br>王女様もまた騎士様に背を任せる後ろ盾である…
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_370015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("エレイン", "喜び")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★エレイン★★:まさに『黒装束の後ろ盾』<br>見事なタイトル回収！素敵です！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_370016")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:い、意気込んでるね…エレイン
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_370018")

-- ▼直接出力
 --PlayPartVoice("エレイン", "照れ")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★エレイン★★:す、すみません…緊張して<br>なんだかカラ回ってるみたいで…！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_370019")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:頑張ろう頑張ろうとし過ぎちゃうとさ<br>ガチガチになっちゃうよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_370021")

-- ▼直接出力
lookat_delay_weight_reset(Actor002 , 0.6)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-69,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:でもそういうエレインが夢見る世界が<br>舞台上なら広がってるわけでしょ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_370022")

-- ▼直接出力
lookat_delay_weight(Actor005, {1.0, 0.08, 0.5, 0.3} , 0.5)
keep_ik_lookat(Actor005, Actor002, "J_Head")
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★エレイン★★:…夢見る世界<br>………舞台上なら
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_370023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力

	--★★ギネヴィア★★:楽しみましょうよ<br>もちろん、本気でね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_370024")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
lookat_delay_weight_reset(Actor005 , 0.6)
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★エレイン★★:…や、やらせてくださいっ！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_370025")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:うんっ<br>じゃあ、早速読み合わせてみましょう
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_370026")

-- ▼直接出力
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★エレイン★★:一度だけの、嘘なら──
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_370028")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102004)
	InitializeLoad_Preload()
	load_area_scene_preload(115020)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
