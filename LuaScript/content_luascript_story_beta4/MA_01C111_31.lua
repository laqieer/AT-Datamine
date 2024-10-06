-- このluaスクリプトは、MA_01C111_31.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_02","114011_02_h")
Include("content_adv_advsmall_114011_02","Template114011_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_002)
	Camera003 = SetTemplate("Actor003",50,CharaPos114011_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114011_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_011)
	Camera005 = SetTemplate("Actor005",nil,CharaPos114011_02_014,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_014)
	Camera006 = SetTemplate("Actor006",nil,CharaPos114011_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_013)
	Camera007 = SetTemplate("Actor007",nil,CharaPos114011_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_011)
	Camera008 = SetTemplate("Actor008",nil,CharaPos114011_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName114011_02,CameraPos114011_02_012)
	InitializeTemplateRandomCamera114011_02()
	InitializeTemplate114011_02()
-- ▼直接出力
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField_MA_01C900_29_2", false)
	gaussian_start = 10
	gaussian_end = 30
 --set_rot(Actor004,{0,125,0})
 --set_pos(Actor004,{-0.03,0,2.75})
Ef_Aura_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
local EfPos = get_pos(Actor004)
set_pos(Ef_Aura_Enemy , EfPos)
Hide(Actor001)
Hide(Actor002)
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor005,Actor007,"J_Head")
keep_ik_lookat(Actor006,Actor007,"J_Head")
keep_ik_lookat(Actor008,Actor007,"J_Head")
-- ▲直接出力
-- ▼直接出力
 --set_rot(Actor003,{0,125,0})
set_pos(Actor003,{-1.075,0,6.559})
Ef001 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, false)
set_pos(Actor004,{-2,0,13.175})
-- ▲直接出力
-- ▼直接出力
set_pos(Ef001,{0.84,0.06,14.42})
-- ▲直接出力
-- ▼直接出力
off_active(Ef001)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
load_image("101040300", "content_still_10104030_image", "101040300_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101040310", "content_still_10104031_image", "101040310_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101040340", "content_still_10104034_image", "101040340_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Serious2")
-- ▲直接出力
-- ▼直接出力
CameraEX_2 = set_camera({0.61,0.7,-0.49,-2.022,8.852,0,11.88175})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","003","101015003","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101045","001","101045001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101046","001","101046001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101047","001","101047001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101048","001","101048001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_2DOnly("101015","001","101015001")
	Actor010 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:ノワールたちのもとにロンディニウム付近で<br>魔女らしき影を見たとの報が入る
	Talk(Actor010,"telop","narration","N","MA_01C111_311001")


	--★★テロップ★★:アーサーの動向を追うため<br>円卓の騎士たちは二手に分かれることに選ぶ
	Talk(Actor010,"telop","narration","N","MA_01C111_311002")


	--★★テロップ★★:ディナタンやモルドレッドらと<br>ルーシャスの救援に向かうノワール
	Talk(Actor010,"telop","narration","N","MA_01C111_311003")


	--★★テロップ★★:一方、ランスロットはギネヴィアらと<br>ロンディニウムへ向かうことになったのだった
	Talk(Actor010,"telop","narration","N","MA_01C111_311004")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,FADE_TIME)
wait_time(FADE_TIME)
show_image("101040300",0,0,0,true,false)
set_position_image(0,-100)
set_scale_image(1.5,1.5)
fadein(FADE_TIME)
scale_to_image(1.0,1.0,20,"Linear")
move_to_image(0,0,20,"Linear")
wait_time(FADE_TIME + 0.5)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Angry")
	change_face(Actor007,"Anger")

	--★★ティーロノエー★★:まっずいんだケド！<br>こんなの何人食べても満足できないんだケド！
	Talk(Actor007,"CHRNAME_SISTERS_6","simple","N","MA_01C111_310002")

	PlayAction(Actor008,"to  Std_No")
	change_face(Actor008,"Smile")

	--★★ティーテン★★:ロノエーちゃん、ズル～い<br>あちしにも食べさせてよ～
	Talk(Actor008,"CHRNAME_SISTERS_7","simple","N","MA_01C111_310003")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Anger")

	--★★グリートーネア★★:あなたたち！<br>今日は様子見だっていわれたでしょう？
	Talk(Actor005,"CHRNAME_SISTERS_4","simple","N","MA_01C111_310004")

	PlayAction(Actor007,"to  Std_Worry")
	change_face(Actor007,"Normal")

	--★★ティーロノエー★★:言ってたのはモーロノエー姉ちゃんでしょ？<br>ウチにはあんまり関係ないもん
	Talk(Actor007,"CHRNAME_SISTERS_6","simple","N","MA_01C111_310005")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
	change_face(Actor008,"Normal")

	--★★ティーテン★★:そーそー
	Talk(Actor008,"CHRNAME_SISTERS_7","simple","N","MA_01C111_310006")

	PlayAction(Actor006,"to  Std_Sad01")

	--★★グリートン★★:だからティーロノエーとティーテンと<br>一緒は嫌だと言ったのに…
	Talk(Actor006,"CHRNAME_SISTERS_5","simple","N","MA_01C111_310007")

	PlayAction(Actor007,"to  Std_Worry")
-- ▼直接出力
Appear(Actor001)
Appear(Actor002)
Appear(Actor003)
set_enable_auto_lookat_all(false)
lookat_delay_weight_reset(Actor001,1)
lookat_delay_weight_reset(Actor002,1)
lookat_delay_weight_reset(Actor003,1)
-- ▲直接出力

	--★★ティーロノエー★★:んん～？<br>美味しそうなヤツらが来たみたい
	Talk(Actor007,"CHRNAME_SISTERS_6","simple","N","MA_01C111_310008")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,FADE_TIME_FAST)
wait_time(FADE_TIME_FAST)
hide_image(0)
se_play("SE_ADV_MA_01A112_18_Footstep")
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
manager.CloseupUpExclusiveCamera(Actor003)
lookat_delay_weight_reset(Actor005,1)
lookat_delay_weight_reset(Actor006,1)
lookat_delay_weight_reset(Actor007,1)
lookat_delay_weight_reset(Actor008,1)
fadein(FADE_TIME_FAST)
wait_time(FADE_TIME_FAST + 0.5)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Anger")

	--★★ギネヴィア★★:魔女が現れたってウワサ<br>本当だったみたいね！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_310010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★パーシヴァル★★:そうみたいだね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C111_310011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:魔女が４人か、相手にとって不足はないね<br>さて、どうするんだい！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C111_310012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:決まっている<br>４人程度であればこの場で斬り捨てるのみだ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C111_310013")

	PlayAction(Actor008,"to  Std_Angry")
	change_face(Actor008,"Anger")

	--★★ティーテン★★:なまいきなまいき～
	Talk(Actor008,"CHRNAME_SISTERS_7","speech","R","MA_01C111_310014")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★グリートーネア★★:大した自信ですね、最強騎士<br>でも、あまり甘く見ないでほしいわ
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","R","MA_01C111_310015")

	change_face(Actor001,"Sad")

	--★★ランスロット★★:…魔女の力が増幅されているのか
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C111_310017")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
 --setup_small_camera_start(CameraEX_2)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Worry")

	--★★グリートン★★:モーロノエーお姉様は<br>まだ大人しくしていろと仰っていたけれど
	Talk(Actor006,"CHRNAME_SISTERS_5","speech","R","MA_01C111_310018")

-- ▼直接出力
 --setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --setup_small_camera_start(Camera006)
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
set_enable_auto_lookat(Actor003,true)
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★グリートン★★:邪魔者は早めに片付けておくわ！
	Talk(Actor006,"CHRNAME_SISTERS_5","speech","R","MA_01C111_310019")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
on_active(Ef001)
se_play("SE_ADV_MA_01A111_04_Witch_BlackFeather")
-- ▲直接出力
-- ▼直接出力
wait_time(2.8)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --setup_small_camera_start(Camera001)
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ランスロット★★:…下がっていろ、ギネヴィア！
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C111_310021")

-- ▼直接出力
 --[[
CameraEX = set_camera({-0.58,1.16,3.28,-3,-8,0,15})
setup_small_camera_start(CameraEX)
slidemove2(CameraEX,{-0.68,1.16,3.28},2.0,2)
on_active(FX_DoF)
 --]]
lookat_weight(Actor003,0.9,0.03,0.7,0)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",2)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:ラ、ランスロット！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_310022")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0,0.2)
--アーサーの剣激
se_play("SE_ADV_MA_01C111_31_Explosion")
wait_time(0.2)
show_image("101040310",0,0,0,true,false)
lookat_delay_weight_reset(Actor003,1)
Appear(Actor004)
turn_lookat( Actor004,Actor007, 0)
turn_lookat(Actor003,Actor004, 0)
turn_lookat(Actor001,Actor004, 0)
turn_lookat(Actor007,Actor004, 0)
turn_lookat(Actor006,Actor004, 0)
turn_lookat(Actor005,Actor004, 0)
turn_lookat(Actor008,Actor004, 0)
off_active(FX_DoF)
wait_time(2.2)
fadein(2.0)
wait_time(4.0)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Serious2")
-- ▲直接出力

	--★★ギネヴィア★★:え…？<br>アーサー…
	Talk(Actor003,"CHRNAME_GUINEVERE","simple","N","MA_01C111_310024")

-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
	change_face(Actor009,"Anger")

	--★★アーサー2★★:ロンディニウムから去れ、魔女どもよ
	Talk(Actor009,"CHRNAME_ARTHUR","simple","N","MA_01C111_310025")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,0.2)
wait_time(0.2)
setup_small_camera_start()
 --setup_small_camera_start(CameraEX_2)
hide_image(0)
fadein(0.2)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Worry")
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor007,"Anger")

	--★★ティーロノエー★★:な、なに言ってんの？<br>アンタひとりで喰らいつくすつもり？
	Talk(Actor007,"CHRNAME_SISTERS_6","speech","R","MA_01C111_310026")

-- ▼直接出力
 --setup_small_camera_start(Camera008)
-- ▲直接出力
	PlayAction(Actor008,"to  Std_No")

	--★★ティーテン★★:ずるいずるい～
	Talk(Actor008,"CHRNAME_SISTERS_7","speech","R","MA_01C111_310027")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,0.2)
wait_time(0.2)
show_image("101040340",0,0,0,true,false)
on_active(Ef_Aura_Enemy) 
play_particle(Ef_Aura_Enemy)
fadein(0.2)
wait_time(0.2)
-- ▲直接出力

	--★★アーサー2★★:何度も言わせるな
	Talk(Actor009,"CHRNAME_ARTHUR","simple","N","MA_01C111_310028")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0,0.2)
--アーサーの剣激
se_play("SE_ADV_MA_01C111_31_Explosion")
wait_time(0.2)
wait_time(2.0)
hide_image(0)
setup_small_camera_start(RndCamera001)
off_active(Ef_Aura_Enemy)
stop_particle(Ef_Aura_Enemy)
fadein(1.0)
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Angry")

	--★★ティーロノエー★★:マ、マゾエー姉ちゃんに<br>言いつけてやるんだから！
	Talk(Actor007,"CHRNAME_SISTERS_6","speech","R","MA_01C111_310030")

	PlayAction(Actor005,"to  Std_Talk")

	--★★グリートーネア★★:いったん退きましょう<br>モーロノエーお姉様と作戦会議よ！
	Talk(Actor005,"CHRNAME_SISTERS_4","speech","R","MA_01C111_310031")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
Hide(Actor008)
set_chara_pos_resetting(Actor004,CharaPos114011_02_011)
turn_lookat(Actor003,Actor004, 0)
turn_lookat(Actor001,Actor004, 0)
 --Camera004=setup_small_camera_resetting(Actor004,CharaPos005,CameraPos005)
 --set_animationcontroller(Actor004,"Chr_005_01_StdController","to Std_Loop")
set_common_look_at(Actor001,Actor004)
set_common_look_at(Actor002,Actor004)
set_common_look_at(Actor003,Actor004)
set_common_look_at(Actor004,Actor002)
set_enable_auto_lookat_all(false)
change_face(Actor004,"Normal")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor004,true)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:アーサー王！ああ、よかった<br>無事だったんだな
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C111_310033")


	--★★パーシヴァル★★:やっぱりボクはわかっていたよ<br>キミがボクたちを裏切るはずがないと…
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C111_310034")

	change_face(Actor004,"Normal")

	--★★アーサー★★:………
	Talk(Actor004,"CHRNAME_ARTHUR","speech","R","MA_01C111_310036")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ランスロット★★:アーサー…その、力は…
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C111_310037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Smile")

	--★★アーサー★★:白々しいな、ランス！<br>お前はわかっていただろう？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","R","MA_01C111_310039")

	change_face(Actor001,"Sad")

	--★★ランスロット★★:…！
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C111_310041")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:ど、どういうことだい…？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C111_310042")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:ね、ねえ、なにかの間違いなんでしょ？<br>一緒に学園に帰りましょうよ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_310043")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Normal")

	--★★アーサー★★:すまないな！俺は帰らない<br>もう道は決まってしまったんだ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","R","MA_01C111_310044")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor003,"Pain")

	--★★ギネヴィア★★:どうして…<br>マーリンだってあなたを待って――
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_310046")

	change_face(Actor004,"Sad")

	--★★アーサー★★:………
	Talk(Actor004,"CHRNAME_ARTHUR","speech","R","MA_01C111_310047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アーサー★★:スノードンにて待っている<br>すべてはそこで話そう?
	Talk(Actor004,"CHRNAME_ARTHUR","speech","R","MA_01C111_310049")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField_MA_01C900_29_2", false)
	gaussian_start = 10
	gaussian_end = 30
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_BlackFeather", false, false)
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101040300", "content_still_10104030_image", "101040300_StillImage")
load_image_preload("101040310", "content_still_10104031_image", "101040310_StillImage")
load_image_preload("101040340", "content_still_10104034_image", "101040340_StillImage")
preload_sound("BGM_ADV_Serious2")
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","003","101015003","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101045","001","101045001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101046","001","101046001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101047","001","101047001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101048","001","101048001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_2DOnly_Preload("101015","001","101015001")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
