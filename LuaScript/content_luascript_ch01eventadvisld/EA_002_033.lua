-- このluaスクリプトは、EA_002_033.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",288,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	Camera002 = SetTemplate("Actor002",-130,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera003 = SetTemplate("Actor003",207.4,CharaPos114011_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_008)
	Camera004 = SetTemplate("Actor004",85,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_CoinTossController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
coin = setup_prop_object(10201016)
-- ▲直接出力
-- ▼直接出力
coin_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
on_parent(coin,Actor004, "Loc_weapon_constrint_R", coin_offset)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to CoinToss01")
se_play("SE_ADV_MA_01B112_49_Cloth")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
-- ▲直接出力
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,0.223, 0.939, 3.402)
-- ▲直接出力
-- ▼直接出力
CameraEx=set_camera({0.44, 1.02, 0.29,   355.7573, 8, 0,   18})
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Sad02")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
temp_tukue1 = setup_prop_object(10112002)
	set_pos(temp_tukue1, {0.2, 0.0, 4.3})
	set_rot(temp_tukue1, {0, 0, 0})
-- ▲直接出力
-- ▼直接出力
coin2 = setup_prop_object(10201016)
coin3 = setup_prop_object(10201016)
coin4 = setup_prop_object(10201016)
coin5 = setup_prop_object(10201016)
coin6 = setup_prop_object(10201016)
coin7 = setup_prop_object(10201016)
coin8 = setup_prop_object(10201016)
coin9 = setup_prop_object(10201016)
coin10 = setup_prop_object(10201016)
coin11 = setup_prop_object(10201016)
coin12 = setup_prop_object(10201016)
coin13 = setup_prop_object(10201016)
coin14 = setup_prop_object(10201016)
coin15 = setup_prop_object(10201016)
-- ▲直接出力
-- ▼直接出力
set_pos(coin2, {0.25,0.816,4.05})
set_pos(coin3, {0.25,0.8205,4.05})
set_pos(coin4, {0.25,0.825,4.05})
set_pos(coin5, {0.25,0.8295,4.05})
set_pos(coin6, {0.25,0.834,4.05})
set_pos(coin7, {0.25,0.8385,4.05})
set_pos(coin8, {0.25,0.843,4.05})
set_pos(coin9, {0.25,0.8475,4.05})
set_pos(coin10, {0.25,0.852,4.05})
set_pos(coin11, {0.25,0.8565,4.05})
set_pos(coin12, {0.25,0.861,4.05})
set_pos(coin13, {0.32,0.816,4.05})
set_pos(coin14, {0.32,0.8205,4.05})
set_pos(coin15, {0.3434,0.8214,4.05})
set_rot(coin15, {0,0,-21.891})
-- ▲直接出力
-- ▼直接出力
baracoin = setup_prop_object(10201016)
baracoin2 = setup_prop_object(10201016)
baracoin3 = setup_prop_object(10201016)
set_pos(baracoin, {0.484,0.816,4.258})
set_pos(baracoin2, {0.183,0.816,4.224})
set_pos(baracoin3, {0.449,0.816,4.447})
-- ▲直接出力
-- ▼直接出力
load_image("102050030", "content_still_10205003_image", "102050030_StillImage")
show_image("102050030", 0.0, 0.0, STILL_SWITCH_TIME ,false,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
CloseTalkWindow()
fadeout(0,0,0,0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN + 0.5)
se_play("SE_ADV_EA_002_041_Coin")
wait_time(1.5)
se_play("SE_ADV_EA_002_041_CoinCatch")
wait_time(1.0)
PlayPartVoiceDirect("山賊","0011")
wait_time(3.0)
hide_image(0.5)
wait_time(1.3)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★山賊★★:当たらんねえ
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033002")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("イゾルデ", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★イゾルデ★★:………もう、一度…！
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_033003")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("山賊","0011")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★山賊★★:簡単なギャンブルじゃないか<br>オレはこれが好きでね
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033004")

-- ▼直接出力
CloseTalkWindow()
wait_time(2.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to CoinToss02")
CloseTalkWindow()
wait_time(1.0)

wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to CoinToss03")
wait_time(2.3)
-- ▲直接出力

	--★★山賊★★:投げたコインをオレが手の甲で受け止める<br>そして、もう片方の手のひらで隠す
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033005")

-- ▼直接出力
CloseTalkWindow()
wait_time(2.5)
-- ▲直接出力

	--★★山賊★★:上になったコインの面は表か裏か<br>その結果で賭けをする『コイントス』
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033006")

-- ▼直接出力
PlayActionDirect(Actor004,"to CoinToss04")
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "肯定3")
-- ▲直接出力

	--★★山賊★★:オマエたちが一度でも勝てれば<br>致死薬を譲る
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033007")


	--★★山賊★★:オレが勝てばそのたびに<br>致死薬の値段の倍額をもらう
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033008")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to CoinToss04_end")
se_play("SE_ADV_MA_01B112_49_Cloth")
SkipDefaultMotion(Actor004)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("山賊", "照れ")
-- ▲直接出力

	--★★山賊★★:そういう条件で始めたわけだが<br>フム…なかなか稼がせてもらったよ
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力

	--★★イゾルデ★★:………もう、一度…お願いするわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_033010")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★山賊★★:先ほど全額賭け切ったじゃないか
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033011")

-- ▼直接出力
setup_small_camera_start(Camera003)
PlayActionDirect(Actor003,"to  Std_Angry")
set_animationcontroller(Actor004, "Chr_030_01_StdController", "to Std_Loop")
PlayPartVoice("ヴォールス", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ヴォールス★★:…冗談ではない。致死薬の値段すら<br>一級品の武具よりも高値をふっかけておいて
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_033012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★山賊★★:致死薬──<br>『ルペトンビターバル』
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033014")

-- ▼直接出力
PlayPartVoiceDirect("山賊","0010")
-- ▲直接出力

	--★★山賊★★:単なる致死毒の<ruby=たぐい>類で</ruby>あればそこらでも買えるが<br>苦しみも痛みもなく死を得られる薬となると希少
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033015")

	PlayAction(Actor004,"to  Std_Talk")

	--★★山賊★★:化け物にいつ喰われるかわからん時代だ<br>苦境に立たされ絶えぬ痛みに晒される者も多い
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033016")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "肯定2")
-- ▲直接出力

	--★★山賊★★:需要も多い。苦に満ちた人生より楽な終わりをと<br>…それを考えれば適正価格だと思わんか
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033101")

	PlayAction(Actor004,"to  Std_No")

	--★★山賊★★:お嬢さんたちのような客は山ほどいるんだよ<br>いきなり押しかけて、売ってくれと言ってくる
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033017")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("山賊","0036")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★山賊★★:だからこうして抽選販売のような真似をしてる<br>当たるかどうかわくわくするだろ？オレもそうさ
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033018")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:当たりがあるからこその抽選だ<br>お前がやっているのはただの道楽でしかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_033019")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("山賊","0019")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★山賊★★:コインの面を選ぶ権利はお嬢さんに譲ってるのに<br>どうして一度として当たらないかねえ
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033020")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0015")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:トスをしているのはお前だ！<br>イカサマとしか──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_033021")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
turn_chara(Actor003,-175,0)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ヴォールス", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:ノワール、待て
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_033023")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0021")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:これじゃあイゾルデがあまりにも──…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_033024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("山賊","0002")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★山賊★★:お嬢さんはこちらの条件をのんで<br>賭けに臨んでいるんだよ？
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0025")
lookat_weight_reset(Actor002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:…そうね、文句を言うのは筋違い………<br>わかっているわ…わかってる
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_033026")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
lookat_weight(Actor003, 0.6, 0.08, 1.0, 0.4)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head", 0.7)
set_common_look_at(Actor001,Actor002,1.0)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("山賊","0037")
-- ▲直接出力

	--★★山賊★★:破滅の覚悟は買うが<br>薬は売れんね
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033027")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CameraEx)
change_face(Actor002,"Sad")
keep_ik_lookat_object(Actor002,nil,"kara")
lookat_delay_weight(Actor002, 0.8, 0.04, 0.8, 0.4,0.6)
wait_time(1.3)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:………すぐに、賭け代を工面して…出直すわ<br>こんなの運次第…、どうかまた…相手を、して
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_033029")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight_reset(Actor002,1.0)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-210,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ヴォールス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ヴォールス★★:イゾルデ…！？いかん、これ以上はドツボだ<br>いくら金を積もうとコイツは──…！
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_002_033030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("山賊", "照れ")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★山賊★★:神に見放されんといいがね
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033031")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("イゾルデ", "否定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★イゾルデ★★:…神頼みなんてしないわ<br>ギャンブルは<dot>当たるか</dot>どうかじゃないもの
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_033032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("山賊","0045")
-- ▲直接出力

	--★★山賊★★:ほう？負け惜しみを聞こうか<br>ではギャンブルとは…なんだというのかね？
	Talk(Actor004,"NPCNAME_0303","speech","N","EA_002_033102")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0013")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:当てるかどうかよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","EA_002_033034")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10201016)
coin_offset = {0,0,0,0,0,0}
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10112002)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
setup_prop_object_preload(10201016)
load_image_preload("102050030", "content_still_10205003_image", "102050030_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
