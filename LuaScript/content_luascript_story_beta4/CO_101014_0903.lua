-- このluaスクリプトは、CO_101014_0903.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",105,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",45,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Sword_01 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
off_parent(Sword_01,Actor001, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
-- ▼直接出力
bow_01 = set_object("content_weapon_105010001", "weapon_model_105010001", true)
weapon_offset = {0,0,0,0,0,-5}
off_parent(bow_01,Actor002, "Loc_weapon_constrint_L",weapon_offset)
-- ▲直接出力
-- ▼直接出力
Book_01 = set_object("content_weapon_107010001", "weapon_model_107010001", true)
weapon_offset = {0,0,0,0,0,-5}
off_parent(Book_01 ,Actor003, "Loc_weapon_constrint_L",weapon_offset)
-- ▲直接出力
-- ▼直接出力
off_active(Sword_01)
off_active(bow_01)
off_active(Book_01)
-- ▲直接出力
-- ▼直接出力
Noi_Pos = {-0.78, 0, 1.2}
set_pos(Actor001,Noi_Pos)
-- ▲直接出力
-- ▼直接出力
Iso_Pos = {0.1, 0, -0.961}
set_pos(Actor003,Iso_Pos)
-- ▲直接出力
-- ▼直接出力
Mob_Pos = {0.6, 0, -1.5}
-- ▲直接出力
-- ▼直接出力
lookat_weight_reset( Actor004)
lookat_weight_reset( Actor005)
lookat_weight_reset( Actor006)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:この洞窟に巨大なドラゴンがいるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_09030002")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("山賊", "喜び")
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:いるわけねえだろ<br>巨大なドラゴンなんてよ！
	Talk(Actor006,"CHRNAME_NAMELES","speech","N","CO_101014_09030004")

-- ▼直接出力
Appear(Actor005)
Appear(Actor006)
CloseTalkWindow()
wait_time(WAIT_TIME_SHORT)
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力

	--★★イゾルデ★★:でしょうねで、どうするつもりだったの？
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_09030006")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "肯定")
-- ▲直接出力

	--★★山賊★★:姫を人質にとって<br>領主の座を明け渡してもらうはずだったのさ
	Talk(Actor005,"NPCNAME_0198","speech","N","CO_101014_09030007")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力

	--★★イゾルデ★★:お生憎様
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_09030008")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:で？空いた座には誰が座るんだい
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09030009")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("貴族_男1", "喜び")
-- ▲直接出力

	--★★貴族（男）②★★:私だよ！
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_09030010")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Camera004 = setup_small_camera_resetting(Actor004,CharaPosDuelCommonFormation01_004,CameraPosDuelCommonFormation01_004)
Camera006 = setup_small_camera_resetting(Actor006,CharaPosDuelCommonFormation01_002,CameraPosDuelCommonFormation01_002)
setup_small_camera_start()
set_pos(Actor006,Mob_Pos)
-- ▲直接出力
-- ▼直接出力
Camera008 = setup_small_camera_resetting(Actor002,CharaPosDuelCommonFormation01_008,CameraPosDuelCommonFormation01_008)
Camera005 = setup_small_camera_resetting(Actor003,CharaPosDuelCommonFormation01_005,CameraPosDuelCommonFormation01_005)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★貴族（男）②★★:あの土地を発展させてきたのは私だ私こそが領主の座にふさわしい！
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_09030012")


	--★★貴族（男）②★★:私は領主を退けドラゴンを倒した英雄として姫と婚姻を結び
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_09030013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("貴族_男1", "笑い")
-- ▲直接出力

	--★★貴族（男）②★★:名実ともにこの地の新たな領主となるのだ
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_09030014")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:欲に目がくらんだ者の末路だね人間なんて軽く裏切るんだ。信じちゃいけない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09030015")

-- ▼直接出力
PlayPartVoice("貴族_男1", "悩む")
-- ▲直接出力

	--★★貴族（男）②★★:円卓の騎士が現れたときはヒヤッとしたがな
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_09030016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0013")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:尻尾をつかむために泳がせてやったんだよ気づかなかったわけ？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09030018")

	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("貴族_男1", "激怒")
-- ▲直接出力

	--★★貴族（男）②★★:ええい、うるさい！貴様らを片付けさえすればいいだけだ！
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_09030019")


	--★★貴族（男）②★★:やはり生贄には姫が必要だった報告とすれば目論見どおりに事が運ぶのだ
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_09030020")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0043")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★トリスタン★★:これだから人間ってやつは
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09030021")

-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,20,0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
set_enable_auto_lookat(Actor003,false)
lookat_delay_weight(Actor003, 0.4, 0.12, 0.8, 0.2, 1)
keep_ik_lookat(Actor003,Actor002,"J_Head")
wait_time(0.2)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:ああいうのも人間でもね、領主も姫も言っていたわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_09030022")


	--★★イゾルデ★★:皆の笑顔を守ってあげたい皆の想いを信じたい…それだけなのです、と
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_09030023")

	change_face(Actor002,"Surprise")

	--★★トリスタン★★:その言葉を信じるとでも？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09030024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:トリスタンは信じないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_09030025")

	change_face(Actor002,"Sad")

	--★★トリスタン★★:………
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09030026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:私は信じたわノワールもね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_09030027")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:例外中の例外で被災地の支援を行うトリスタンその手は誰のためにあるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_09030028")

	change_face(Actor002,"Surprise")

	--★★トリスタン★★:ボクの手は…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09030030")

-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★イゾルデ★★:ふふっ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_09030032")

-- ▼直接出力
setup_small_camera_end()
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",0.5)
on_active(Sword_01)
on_active(bow_01)
on_active(Book_01)
set_animationbattlecontroller(Actor001,1,False)
on_parent(Sword_01,Actor001, "Loc_weapon_constrint_R",weapon_offset)
SkipDefaultMotion(Actor001)
set_animationbattlecontroller(Actor002,8,False)
on_parent(bow_01,Actor002, "Loc_weapon_constrint_L",weapon_offset)
SkipDefaultMotion(Actor002)
set_animationbattlecontroller(Actor003,12,true)
on_parent(Book_01,Actor003, "Loc_weapon_constrint_L",weapon_offset)
SkipDefaultMotion(Actor003)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("貴族_男1","0010")
-- ▲直接出力

	--★★貴族（男）②★★:円卓の騎士がなんだ！数はこちらのほうが上だ！邪魔するというなら排除するまで！
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_09030033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★トリスタン★★:やれやれ<br>円卓の騎士も舐められたものだね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09030034")

-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
se_play("SE_Atk_Swd_001")
wait_time(0.4)
se_play("SE_Atk_Bow_001")
wait_time(0.3)
PlayPartVoiceDirect("山賊","0028")
wait_time(0.3)
se_play("SE_ADV_MA_01C111_21_Sword")
wait_time(0.2)
PlayPartVoiceDirect("貴族_男1","0044")
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_トリスタン_ランクアップ9_4")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
set_object_preload("content_weapon_105010001", "weapon_model_105010001", true)
weapon_offset = {0,0,0,0,0,-5}
set_object_preload("content_weapon_107010001", "weapon_model_107010001", true)
weapon_offset = {0,0,0,0,0,-5}
Noi_Pos = {-0.78, 0, 1.2}
Iso_Pos = {0.1, 0, -0.961}
Mob_Pos = {0.6, 0, -1.5}
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
