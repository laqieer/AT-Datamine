-- このluaスクリプトは、EA_002_023.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_05","110111_05_h")
Include("content_adv_advsmall_110111_05","Template110111_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_05_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_05,CameraPos110111_05_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_05_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_05,CameraPos110111_05_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110111_05,CameraPos110111_05_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110111_05,CameraPos110111_05_005)
	Camera005 = SetTemplate("Actor005",0,CharaPos110111_05_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110111_05,CameraPos110111_05_008)
	Camera006 = SetTemplate("Actor006",180,CharaPos110111_05_009,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110111_05,CameraPos110111_05_009)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110111_05_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110111_05,CameraPos110111_05_004)
	InitializeTemplateRandomCamera110111_05()
	InitializeTemplate110111_05()
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
  prop_001    = load_particle("content_prop_10104007", "10104007_PropModel", false, false)
    set_pos(prop_001,{-7.95, 0.815, -1.441})
    set_rot(prop_001,{0,90.1,0})
-- ▲直接出力
-- ▼直接出力
   prop_002    = load_particle("content_prop_10104007", "10104007_PropModel", false, false)
    set_pos(prop_002,{-7.946, 0.815, -2.293})
    set_rot(prop_002,{0,-90,0})
-- ▲直接出力
-- ▼直接出力
    prop_003    = load_particle("content_prop_10104007", "10104007_PropModel", false, false)
    set_pos(prop_003,{-5.219, 0.815, 0.815})
    set_rot(prop_003,{0,-180.8,0})
-- ▲直接出力
-- ▼直接出力
    prop_004    = load_particle("content_prop_10104002", "10104002_PropModel", false, false)
    set_pos(prop_004,{-5.527, 0.815, 1.099})
    set_rot(prop_004,{0,-68.5,0})
-- ▲直接出力
-- ▼直接出力
   prop_005    = load_particle("content_prop_10104014", "10104014_PropModel", false, false)
    set_pos(prop_005,{-5.536, 0.815, 0.575})
    set_rot(prop_005,{0,-115.9,0})
-- ▲直接出力
-- ▼直接出力
on_active(prop_001)
on_active(prop_002)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{-7.944, 0, -2.659})
set_pos(temp_isu12,{-7.942, 0, -2.669})
set_pos(Actor006,{-7.944, 0, -1.023,})
set_pos(temp_isu11, {-7.944, 0, -1.06})
set_pos(temp_isu10, {-8.48, 0.0, -1.88})
set_pos(temp_isu9, {-7.3, 0.0, -1.88})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:イカサマと<ruby=そし>誹</ruby>る？
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_023002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0033")
-- ▲直接出力

	--★★イゾルデ★★:お前は盤面を揃えただけでしょう<br>文句を言う気はないわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_023003")

-- ▼直接出力
setup_small_camera_start(RndCamera010)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor005,"Smile")

	--★★ガウェイン★★:うめえなァッ！！うわー最高だぜ油乗ってて！<br>こっちは素材の味が生きてるッ！素材うめえ～！
	Talk(Actor005,"CHRNAME_GAWAIN","speech","N","EA_002_023005")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "喜び")
-- ▲直接出力
	on_cutin(2,Actor006,"Smile")

	--★★ラグネル★★:アアーッ、ノワールにも食べさせたげたいねえ！<br>おいしすぎて止まらないから無理だけど！！
	Talk(Actor006,"CHRNAME_RAGNAR","speech","N","EA_002_023006")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.44)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0037")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:………ごめん、イゾルデ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_023007")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0025")
-- ▲直接出力

	--★★イゾルデ★★:つまり、リオネスがクレアの差し金…<br>妨害工作がナシとは言ってなかったものね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_023008")


	--★★イゾルデ★★:…やっとノワールが屋台に辿り着いたものの<br>リオネスの妨害のせいで──
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_023009")

	PlayAction(Actor007,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★リオネス★★:売り切れだ！！<br>またのお越しを！！
	Talk(Actor007,"CHRNAME_LYONESS","speech","L","EA_002_023011")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定3")
-- ▲直接出力

	--★★クレア★★:良い肉がヴォールスの元に入ったから<br>それで釣った、というわけでは決してないわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_023012")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "照れ")
-- ▲直接出力

	--★★リオネス★★:決して良い肉に釣られたわけじゃないぞ！！
	Talk(Actor007,"CHRNAME_LYONESS","speech","L","EA_002_023013")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:ノワールはがんばったわ<br>謝ることなくてよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_023015")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★ノワール★★:けど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_023016")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クレア★★:手札は見せないものであるからして
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_023018")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
Appear(Actor004)
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:…ええ。同感ね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_023101")

-- ▼直接出力
setup_small_camera_start(Camera004)
change_face(Actor003,"Surprise")
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
voice_play("VO_101032_sp_0001_1")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガレス★★:ノワール！<br>『うきうきプレミアム感謝デーランチ』お待ち♪
	Talk(Actor004,"CHRNAME_GARETH","speech","L","EA_002_023020")

-- ▼直接出力
fadeout(0,0,0,1.0,0.6)
wait_time(0.6)
se_play("SE_ADV_MA_01C109_26_Food_Tray")
CloseTalkWindow()
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
on_active(prop_003)
on_active(prop_004)
on_active(prop_005)
-- ▲直接出力
-- ▼直接出力
CameraEX = set_camera({-5.059, 2.018, 0.656,   71.54073, 292.3593, 0.00145,   30.36522})
setup_small_camera_start(CameraEX)
turn_chara(Actor004,36.4,0)
-- ▲直接出力
-- ▼直接出力
fadein(0.6)
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ど、どうして…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_023022")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0038")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ガレス★★:「日頃もっとも身を削るノワールに労いを」って<br>イゾルデから予約が入ってさ
	Talk(Actor004,"CHRNAME_GARETH","speech","L","EA_002_023023")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガレス★★:コレ、秘密だし特別だよ～♪<br><ruby=ひいき>贔屓</ruby>はあんまりしたくないからさ！
	Talk(Actor004,"CHRNAME_GARETH","speech","L","EA_002_023024")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.1)
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
se_play("SE_ADV_CO_101030_0303_Foot_1_Person")
wait_time(CHARA_IN_WAIT + 1.0)

Hide(Actor004)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0010")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★イゾルデ★★:盤面を整えただけよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_023027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0033")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クレア★★:…わたしの負けね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_023028")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0011")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor001,"Smile")

	--★★ノワール★★:やったな！イゾルデ！！<br>俺はなんの役にも立ってないけど！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","EA_002_023029")

-- ▼直接出力
turn_chara(Actor004,-9.9,0)
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	on_cutin(2,Actor002,"Smile")

	--★★イゾルデ★★:ふふ。賭けに乗ってくれただけで十分よ<br>そのほかでお前はなんの役にも立ってないけれど
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_023030")

	close_cutin()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-10,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:早くその『特別な薬』を手に入れよう<br>そもそもどういう薬なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_023031")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:食事がおいしくなくなるわ<br>冷めないうちにどうぞ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_023033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:致死薬よ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_023035")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
change_face(Actor001,"Surprise")
PlayActionDirect(Actor001,"to Std_Surp")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:………そう<br>安楽な死への薬
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_023037")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:口をつぐむはずよね。司祭も
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_023038")

-- ▼直接出力
CloseTalkWindow()
wait_time(2.2)
lookat_delay_weight_reset(Actor002 , 0.6)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-180,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:支払い、よろしくね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_023039")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Surp")
change_face(Actor001,"Surprise")
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  load_particle_preload("content_prop_10104007", "10104007_PropModel", false, false)
   load_particle_preload("content_prop_10104007", "10104007_PropModel", false, false)
    load_particle_preload("content_prop_10104007", "10104007_PropModel", false, false)
    load_particle_preload("content_prop_10104002", "10104002_PropModel", false, false)
   load_particle_preload("content_prop_10104014", "10104014_PropModel", false, false)
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
