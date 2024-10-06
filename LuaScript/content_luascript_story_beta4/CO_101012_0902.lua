-- このluaスクリプトは、CO_101012_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_01","110141_01_h")
Include("content_adv_advsmall_110141_01","Template110141_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_001)
	Camera002 = SetTemplate("Actor002",150,CharaPos110141_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110141_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110141_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110141_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SleepController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110141_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_007)
	InitializeTemplateRandomCamera110141_01()
	InitializeTemplate110141_01()
-- ▼直接出力
DontCameraOffset(Actor007)
huton = setup_prop_object(10107002)
set_pos(huton,{3.385,0.05,1.41})
set_rot(huton,{0,270,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007, {4.282,0.725,1.457,270.000})
set_rot(Actor007,{0,270,0})
CameraEx = set_camera(2.25886083,2.61035299,0.97707057,44.6036987,72.8436661,0,18.8)
Camera007 = manager.RegisterExclusiveCamera(CameraEx, Actor007)
chair_01 = get_object("geo_chairB")
set_pos(chair_01,{-2.045,0,2.861})
set_rot(chair_01,{0,90,0})
prop001=setup_prop_object(10101017)
prop001_offset={0,0,0,0,0,0}
on_parent(prop001,Actor008,"Loc_weapon_constrint_R", prop001_offset)
on_active(prop001)
set_animationcontroller(Actor008,"Chr_004_01_SitController","to Sit01_Loop")
SkipDefaultMotion(Actor008)
PlayActionDirect(Actor008,"to hurp_loop")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Dinatan_Stage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_2DOnly("101014","001","101014001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…なんだか、緊張してきちゃった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020002")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定2")
-- ▲直接出力

	--★★マルディサント★★:学園祭であれだけ堂々と歌っといて<br>今さらかよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_09020003")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Shy")

	--★★ディナタン★★:そ、それはそうだけど<br>あのときとは状況も雰囲気も違うっていうか…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…こんなときに歌なんてって、思われないかな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101012_09020007","CO_101012_09020008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:大丈夫<br>みんな楽しみにしてるって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_09020010")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:そう、かな…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020011")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★イゾルデ★★:ええ、私もそう思うわ<br>お前の歌声はきっと患者たちの励ましになる
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","CO_101012_09020012")

	change_face(Actor004,"Laugh")

	--★★イゾルデ★★:ここまで頑張ってきたのなら<br>自信を持ちなさい
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","CO_101012_09020013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ここまで頑張って準備してきただろ<br>がんばれ、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_09020015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:そ…そうだよね<br>頑張らなきゃ…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:そうそう。アタシらが書いた最高の歌詞<br>みんなに届けてやるんだろ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_09020017")

	change_face(Actor008,"Normal")

	--★★トリスタン★★:ボクが作った曲に乗せて、ね
	Talk(Actor008,"CHRNAME_TRISTAN","speech","L","CO_101012_09020018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…うん！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020019")

	goto Block1end

::Block1end::
-- ▼直接出力
set_enable_auto_lookat(Actor002, false) --自動首振り制御
lookat_delay_weight_reset(Actor002,1) --向く方向をリセット　第2引数はスピード倍率
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…こんにちは、みなさん<br>今日はみなさんに歌を届けたくて来ました
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020021")


	--★★ディナタン★★:無理に身体を起こさないで<br>ただ耳を傾けてくれれば、それだけで大丈夫です
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020022")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_CO_101012_0902_Clap_Multi")
-- ▲直接出力
-- ▼直接出力
wait_time(3.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:こんな状況で歌なんて聞いてもな…
	Talk(Actor005,"NPCNAME_0226","speech","N","CO_101012_09020024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("女子1", "落胆")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:歌より痛み止めの薬がほしいよ<br>ディナタンには悪いけど…
	Talk(Actor006,"NPCNAME_0227","speech","N","CO_101012_09020025")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:…私は、この学園が大好きです
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020027")


	--★★ディナタン★★:最初は友達がなかなかできなくて<br>寂しい思いもしたけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:でも、少しずつお友達も増えて…<br>私の歌が好きだと言ってくれる人もいて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020029")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:いつの間にか、ここは私にとって<br>かけがえのない場所になっていました
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020030")


	--★★ディナタン★★:みんなが元気に青春を謳歌している<br>この学園が大好き
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020031")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:この学園にいる、みんなのことが大好き
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020032")


	--★★ディナタン★★:…そんな気持ちを込めて、<br>大切な人たちと一緒に歌を作りました
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:…傷ついたみなさんの心が<br>どうか少しでも癒されますように
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_09020034")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Dinatan_Stage")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor008,"to hurploop_hurpplay")
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Worry")
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
bgm_play("Set_BGM_Bus_Volume")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:…なんて優しい歌声なんだ
	Talk(Actor005,"NPCNAME_0226","speech","N","CO_101012_09020036")

-- ▼直接出力
PlayPartVoice("女子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:あったかい…<br>キズの痛みが、和らいでく…
	Talk(Actor006,"NPCNAME_0227","speech","N","CO_101012_09020037")

	change_face(Actor004,"Surprise")

	--★★イゾルデ★★:…患者たちの顔色がよくなっていくわ<br>まるで奇跡ね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","CO_101012_09020038")

-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★トリスタン_台詞★★:患者たちだけじゃないみたいだよ
	Talk(Actor009,"CHRNAME_TRISTAN","speech","L","CO_101012_09020039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:ああ。なんつーか<br>身体が軽くなってる気がする…
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_09020040")

	change_face(Actor003,"Smile")

	--★★マルディサント★★:それに…なんだか心が落ち着くっつーか…<br>まるで優しい光に包まれてるみたいだ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","CO_101012_09020041")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★イゾルデ★★:そうね…私も感じるわ<br>…これが、あの子の歌の力なのね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","CO_101012_09020042")

-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン_台詞★★:キミは知っていたのかい？ノワール
	Talk(Actor009,"CHRNAME_TRISTAN","speech","L","CO_101012_09020043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ。昔から、ディナタンの歌は<br>俺たちに元気をくれた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_09020044")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:自慢の妹だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_09020045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:心も、体も癒されていく<br>まるで、妖精の歌声みたいだ
	Talk(Actor007,"NPCNAME_0239","speech","L","CO_101012_09020047")


	--★★キャメロット騎士学術院（男）③★★:やっと、君の歌が聞けた<br>………ありがとう、ディナタン
	Talk(Actor007,"NPCNAME_0239","speech","L","CO_101012_09020048")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_Volume")
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("ディナタン_コミュランク", "ディナタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10107002)
setup_prop_object_preload(10101017)
prop001_offset={0,0,0,0,0,0}
preload_sound("BGM_ADV_Dinatan_Stage")
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_2DOnly_Preload("101014","001","101014001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
