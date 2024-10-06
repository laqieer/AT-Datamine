-- このluaスクリプトは、EA_072_032.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111042_02","111042_02_h")
Include("content_adv_advsmall_111042_02","Template111042_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111042_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_011)
	Camera002 = SetTemplate("Actor002",-8,CharaPos111042_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_024_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_002)
	Camera003 = SetTemplate("Actor003",8,CharaPos111042_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_001)
	Camera004 = SetTemplate("Actor004",-2,CharaPos111042_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_002)
	Camera005 = SetTemplate("Actor005",-7,CharaPos111042_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111042_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_011)
	InitializeTemplateRandomCamera111042_02()
	InitializeTemplate111042_02()
-- ▼直接出力
Hide(Actor001)
Hide(Actor006)
set_pos(Actor001,{12.563,-0.07,-33.024})
set_pos(Actor002,{8.217,-0.036,-21.792})
set_pos(Actor003,{5.55,-0.02,-23.12})
set_pos(Actor004,{6.984,-0.02,-22.304})
set_pos(Actor005,{10.308,-0.02,-22.499})
-- ▲直接出力
-- ▼直接出力
lookat_weight_reset(Actor003)
lookat_weight_reset(Actor004)
lookat_weight_reset(Actor005)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_Noir")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111042)
	Actor001 = InitializeCharacter_3D("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101058","001","101058001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401037","001","401037001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ライエンス","0007")
-- ▲直接出力

	--★★ライエンス★★:私は蘇った
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320004")

-- ▼直接出力
setup_small_camera_start(RndCamera011)
-- ▲直接出力

	--★★ライエンス★★:このアントニヌス・ウォールは今や<br>我らカレドニアのものだ
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320005")


	--★★ライエンス★★:島の南北に横たわるこの長城は<br>かつてのローマ王の名が冠されているという
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320006")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ライエンス","0034")
-- ▲直接出力

	--★★ライエンス★★:だが、それは我が居城として<br>相応しくないのでな
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320007")


	--★★ライエンス★★:ログレス王アーサーを討ったあかつきには<br>この竜のごとく連なる長城の名を──
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ライエンス","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ライエンス★★:『ペンドラゴン城』と改めようか
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320009")

-- ▼直接出力
change_face(Actor002,"Normal")
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0036_1")
-- ▲直接出力

	--★★ノワール★★:どこまでも借り物だな<br>ライエンス
	Talk(Actor001,"CHRNAME_NAMELES","speech","N","EA_072_0320011")

-- ▼直接出力
CloseTalkWindow()
change_face(Actor002,"Surprise")
--ノワール,CHRNAME_NOIR @名前変更
setup_small_camera_start()
Appear(Actor001)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{9.159,-0.04,-25.365},3.0)
wait_time(0.5)
PlayActionDirect(Actor002,"to Wlk")
PlayActionDirect(Actor003,"to Wlk")
PlayActionDirect(Actor004,"to Wlk")
PlayActionDirect(Actor005,"to Wlk")
turn_lookat(Actor002,Actor006,0.8)
turn_lookat(Actor003,Actor006,0.8)
turn_lookat(Actor004,Actor006,0.8)
turn_chara(Actor005,-178,0.8)
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(1.2)
setup_small_camera_start(Camera001)
wait_time(0.5)
slidemove(Actor001,{9.159,0.0,-25.365},0.3)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:今回の蜂起…なにが目的だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ライエンス","0039")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ライエンス★★:…王たる私が、かつて望んだことのすべてだ<br>ログレスの制圧、ブリテンの支配──
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320014")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:それは…ライエンス当人の望みでは<br>なかったはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320015")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:彼がバルバロイに侵され、歪んだ結果<br>そんなことを企んだだけで──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ライエンス","0011")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ライエンス★★:せっかく王として生きるのだ<br>金と権力を欲しがってなにが悪い？
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320017")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:………そうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ライエンス","0008")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ライエンス★★:我らはこれよりログレスを潰しに向かう<br>どけ。用済みの継承者よ
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320019")


	--★★ノワール★★:…用済み？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ライエンス★★:であろう？
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320021")


	--★★ライエンス★★:キサマは伝承に従い<br>バルバロイを排除した
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320022")


	--★★ライエンス★★:そして己の武器を未来へ継承した
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Appl")
-- ▼直接出力
PlayPartVoiceDirect("ライエンス","0012")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ライエンス★★:キサマは役目を終えたのだ<br>数多の犠牲を経てな
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320024")


	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320025")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ライエンス★★:キサマに残された責務は<br>あとひとつだけだ
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320026")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:それは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ライエンス★★:死だ
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320028")


	--★★ライエンス★★:多くを消し去った責任を取り<br>死すべきだとは思わぬか？
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ライエンス","0013")
-- ▲直接出力

	--★★ライエンス★★:たったひとつの武器を継承するために<br>どれだけのものを見送った？
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320030")


	--★★ライエンス★★:そのたったひとつの武器が<br>もしここにいたならば──
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320031")

	change_face(Actor002,"Smile")

	--★★ライエンス★★:恨み言のひとつも吐くであろうな？
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320032")

-- ▼直接出力
setup_small_camera_start(RndCamera011)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ライエンス★★:「なぜ自分ひとりだけが<br>いなくならなければならないのか」と
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320033")


	--★★ライエンス★★:「自分は名前すら忘れ去られ<br>キサマだけが英雄としてもてはやされるのか」
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320035")

	change_face(Actor002,"Normal")

	--★★ライエンス★★:そうしてキサマは<br>これからどこへ行く？
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320036")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ライエンス","0033")
-- ▲直接出力

	--★★ライエンス★★:旅をして、思い出に浸り<br>罪を償ったフリをするのか？
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320037")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0017")
-- ▲直接出力

	--★★ノワール★★:黙れ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ライエンス","0041")
-- ▲直接出力

	--★★ライエンス★★:死出の旅へ赴け<br>それこそが弔いだ
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320039")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0015")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:黙れ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ライエンス★★:このカレドニア王が見送ってやろう
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320041")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:本人じゃないだろう？あんたは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320042")

-- ▼直接出力
PlayPartVoiceDirect("ライエンス","0015")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ライエンス★★:………なにを言う
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320043")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0020")
-- ▲直接出力

	--★★ノワール★★:もういないひとの言葉を騙るな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320044")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ライエンス","0019")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ライエンス★★:ここに、いるではないか<br>この私こそが──
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320045")

-- ▼直接出力
setup_small_camera_start(RndCamera011)
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いなくなったひとの声なんて<br>もう聞こえない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320046")

-- ▼直接出力
setup_small_camera_start(Camera001)
bgm_play("BGM_Battle_Noir")
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:そのひとがくれたものだけが、遺るんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320047")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0056")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はそれを手放したくない<br>だから、まだ死ねない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ライエンス","0016")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ライエンス★★:勇敢なるカレドニア兵士諸君<br>孤独な継承者様を殺せ。全軍をもってな
	Talk(Actor002,"CHRNAME_LAIENS","speech","R","EA_072_0320049")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
local sword001 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", false)
on_parent(sword001,Actor003,"J_Hand_R",{-0.07,-0.02,0,0,-170,0})

local sword002 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", false)
on_parent(sword002,Actor004,"J_Hand_R",{-0.07,-0.02,0,0,-170,0})

local sword003 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", false)
on_parent(sword003,Actor005,"J_Hand_R",{-0.07,-0.02,0,0,-170,0})
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Squareoff_Loop")
PlayActionDirect(Actor004,"to Std_Squareoff_Loop")
PlayActionDirect(Actor005,"to Std_Squareoff_Loop")
se_play("SE_Handling_Swd_001")
wait_time(1.0)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:彼女が俺にくれたものは<br>きらきらしたものばかりじゃなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320051")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ノワール★★:いいものばっかりじゃ、なかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320052")

	change_face(Actor001,"Normal")

	--★★ノワール★★:この孤独すら、くれたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320053")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:それでいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320054")

-- ▼直接出力
CloseTalkWindow()
local sword004 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", false)
on_parent(sword004,Actor001,"J_Hand_R",{-0.07,-0.02,0,0,-170,0})
PlayActionDirect(Actor001,"to Std_Squareoff_Loop")
se_play("SE_Handling_Swd_001")
SkipDefaultMotion(Actor001)
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:それこそ、キミのいた意味だから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0320056")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_Battle_Noir")
	InitializeLoad_Preload()
	load_area_scene_preload(111042)
	InitializeCharacter_3D_Preload("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101058","001","101058001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401037","001","401037001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111042_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
