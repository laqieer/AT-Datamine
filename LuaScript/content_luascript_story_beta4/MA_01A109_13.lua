-- このluaスクリプトは、MA_01A109_13.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",13,CharaPos110061_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110061_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_004)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
load_image("MA01A1091301", "content_still_10103001_image", "101030010_StillImage")
-- ▲直接出力
-- ▼直接出力
note = setup_prop_object(10106001)
set_pos(note,{4.185, 0.817, 10.435})
set_rot(note,{0,180,0})
book = setup_prop_object(10103003)
set_pos(book,{3.885, 0.817, 10.435})
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115061)
	Actor001 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力

	--★★ラヴェイン★★:次の問題は自分で解いてみてください
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","MA_01A109_130002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン座★★:うん
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A109_130003")

-- ▼直接出力
CloseTalkWindow()
show_image("MA01A1091301", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラヴェイン★★:ログレスを離れていたぶん<br>取り戻さないといけませんね
	Talk(Actor001,"CHRNAME_LOVEIN","simple","N","MA_01A109_130004")


	--★★エレイン座★★:お兄ちゃん…
	Talk(Actor003,"CHRNAME_ELAINE","simple","N","MA_01A109_130005")


	--★★ラヴェイン★★:なんですか？
	Talk(Actor001,"CHRNAME_LOVEIN","simple","N","MA_01A109_130006")

-- ▼直接出力
 --PlayPartVoice("エレイン", "悩む")
-- ▲直接出力

	--★★エレイン座★★:また戦うんだよね<br>学園の人たちは
	Talk(Actor003,"CHRNAME_ELAINE","simple","N","MA_01A109_130007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力

	--★★ラヴェイン★★:ええ。今回の件はほぼ確実にローマの蛮行<br>明確な意図は不明ですが止めなければなりません
	Talk(Actor001,"CHRNAME_LOVEIN","simple","N","MA_01A109_130008")


	--★★ラヴェイン★★:同時に聖杯も見つけ出さなきゃならない
	Talk(Actor001,"CHRNAME_LOVEIN","simple","N","MA_01A109_130009")


	--★★エレイン座★★:お兄ちゃんは、戦わないよね
	Talk(Actor003,"CHRNAME_ELAINE","simple","N","MA_01A109_130010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力

	--★★ラヴェイン★★:私はもう決めました。選ぶのは貴方です
	Talk(Actor001,"CHRNAME_LOVEIN","simple","N","MA_01A109_130011")


	--★★ラヴェイン★★:そこの貴方は、どういうおつもりで？
	Talk(Actor001,"CHRNAME_LOVEIN","simple","N","MA_01A109_130013")

-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力

	--★★エレイン座★★:…え？
	Talk(Actor003,"CHRNAME_ELAINE","simple","N","MA_01A109_130014")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera004)
hide_image(STILL_SWITCH_TIME)
character_in_move_walk_offset(Actor004,CharaPos004,-2.5,0,-1.5,2.0)
wait_time(STILL_PASSIVE_AFTER + FADE_AFTER_TIME)
setup_small_camera_end()
SkipOffsetCamera(Camera004)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor001,-25,0.5)
 --PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラシア★★:ロンディニウムの虐殺がローマの悪行だと<br>なぜ言い切れます
	Talk(Actor004,"CHRNAME_RASIA","speech","L","MA_01A109_130016")

	change_face(Actor003,"Surprise")

	--★★エレイン座★★:ラシア、さん………？
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A109_130017")

	change_face(Actor004,"Anger")

	--★★ラシア★★:教えてください
	Talk(Actor004,"CHRNAME_RASIA","speech","L","MA_01A109_130019")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラシア★★:この学園であの日の惨状を見たのは<br>あなたたちだけです
	Talk(Actor004,"CHRNAME_RASIA","speech","L","MA_01A109_130020")


	--★★ラシア★★:ローマの者がなぜ<br>あんな虐殺を行う必要があります？
	Talk(Actor004,"CHRNAME_RASIA","speech","L","MA_01A109_130021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Anger")

	--★★ラシア★★:どうして、どうして…<br>ルーシャスに従おうとする者がいるんです…？
	Talk(Actor004,"CHRNAME_RASIA","speech","L","MA_01A109_130022")

-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定3")
-- ▲直接出力

	--★★ラヴェイン★★:貴方が本当に知りたいコトは<br>あとに述べたほうですね？
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","MA_01A109_130023")

	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ラシア", "否定")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラシア★★:…なにを知りたいのかすら、今はわかりません
	Talk(Actor004,"CHRNAME_RASIA","speech","L","MA_01A109_130024")

-- ▼直接出力
CloseTalkWindow()
--フェードアウト
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
Appear(Actor002)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:ラシアさん
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_130025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:…誰かが、変わってしまわれたのですか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_130027")


	--★★エレイン★★:変わってしまった誰かが<br>自分を置いていこうとしているんですか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_130029")

	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラシア★★:どう、して…そんなことを──
	Talk(Actor004,"CHRNAME_RASIA","speech","L","MA_01A109_130030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:飲み込めませんよね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_130031")

-- ▼直接出力
 --PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラシア★★:………私は
	Talk(Actor004,"CHRNAME_RASIA","speech","L","MA_01A109_130032")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
se_play("SE_ADV_MA_01105_24_Footstep")
wait_time(2.2)
Hide(Actor004)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor001,30,0.5)
lookat_weight(Actor001,1.0,0.5,1.0,0.5)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラヴェイン★★:…『ラシア』<br>彼女は確か、ローマ大将軍の──
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","MA_01A109_130034")

-- ▼直接出力
turn_chara(Actor002,-90,0.5)
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.5)
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:お兄ちゃん
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_130035")

-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラヴェイン★★:なんです、エレイン？
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","MA_01A109_130036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン★★:………花が、見たいな
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_130037")

	change_face(Actor001,"Smile")

	--★★ラヴェイン★★:決断を先延ばしにするのも自由ですよ<br>私は従います
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","MA_01A109_130038")

-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力

	--★★エレイン★★:…冷たいね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_130039")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラヴェイン★★:その問題集が全部解けてから…<br>行きましょうか
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","MA_01A109_130040")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("MA01A1091301", "content_still_10103001_image", "101030010_StillImage")
setup_prop_object_preload(10106001)
setup_prop_object_preload(10103003)
	InitializeLoad_Preload()
	load_area_scene_preload(115061)
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
