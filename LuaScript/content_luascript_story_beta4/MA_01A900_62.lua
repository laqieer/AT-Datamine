-- このluaスクリプトは、MA_01A900_62.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113011_04","113011_04_h")
Include("content_adv_advsmall_113011_04","Template113011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos113011_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_MA01A900_62_Controller","to Std_Loop",CameraAssetBundleName113011_04,CameraPos113011_04_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos113011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_MA01A900_62_Controller","to Sit01_Loop",CameraAssetBundleName113011_04,CameraPos113011_04_001)
	InitializeTemplateRandomCamera113011_04()
	InitializeTemplate113011_04()
-- ▼直接出力
load_image("10101015", "content_still_10101015_image", "101010150_StillImage") 
-- ▲直接出力
-- ▼直接出力
load_image("10101015_1", "content_still_10101015_image", "101010150_StillImage") 
-- ▲直接出力
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10103012_anim", "10103012_StillAnim", nil, nil, nil, "Root")
-- ▲直接出力
-- ▼直接出力
CUT_01 = cat_template_camera("P10_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_02 = cat_template_camera("P11_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_03 = cat_template_camera("P12_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_04 = cat_template_camera("P13_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_05 = cat_template_camera("P14_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_06 = cat_template_camera("P15_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_07 = cat_template_camera("P16_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_08 = cat_template_camera("P17_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_09 = cat_template_camera("P18_Cam")
-- ▲直接出力
-- ▼直接出力
Chair_02 = get_object("geo_chair_02")
set_pos(Chair_02, {0.63, 0.0, -4.23})
set_rot(Chair_02, {0, 0.0, 0})
-- ▲直接出力
-- ▼直接出力
Sewing = set_object("content_prop_10108001", "10108001_PropModel", true)
set_object_name(Sewing,"10108001_PropModel")
-- ▲直接出力
-- ▼直接出力
on_parent(Sewing,Actor002, "Loc_weapon_constrint_R", 0,0,0, 0,0,0)
-- ▲直接出力
-- ▼直接出力
on_screencolor(IMAGE_COLOR, 0, -50)
-- ▲直接出力
-- ▼直接出力
load_image("10103023", "content_still_10103023_image", "101030230_StillImage") 
-- ▲直接出力
-- ▼直接出力
load_image("10103024", "content_still_10103024_image", "101030240_StillImage") 
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Surprise")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_01)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()


	--★★ギネヴィア★★:『不格好なコート』ぉ？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A900_620002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_02)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:…名前カッコ悪ぅ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A900_620004")


	--★★ギネマウア★★:カレドニアに雇われているという<br>傭兵団のようね
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_620005")

	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:あの国についてるっていうのが<br>まずもってユルセナイ感じ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A900_620006")

-- ▼直接出力
CloseTalkWindow()
show_image("10103023", 0.0, 0.0, STILL_SWITCH_TIME,true,false)
wait_time(STILL_SWITCH_TIME)
-- ▲直接出力

	--★★ギネマウア★★:どうやらその団長が纏う<br>大ぶりな金色のコートが由来の模様よ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","simple","N","MA_01A900_620007")


	--★★ギネヴィア★★:金ンン…？
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_620008")


	--★★ギネマウア★★:まずもって本物の純金ではないでしょうね<br>どうせ金のイミテーションのような
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","simple","N","MA_01A900_620009")


	--★★ギネヴィア★★:ふうん<br>見かけ倒しね
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_620010")

-- ▼直接出力
CloseTalkWindow()
fadeout(255, 255, 255, 1.0, STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME)
show_image("10103024", 0.0, 0.0, 0,true,false)
fadein(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME)
-- ▲直接出力

	--★★ギネマウア★★:父の仇を追って復讐の旅路…<br>狙いは最強騎士様との噂ね
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","simple","N","MA_01A900_620011")


	--★★ギネヴィア★★:はああ？<br>勝てると思ってんのかしら
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_620013")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_03)
wait_time(0.3)
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
-- ▲直接出力

	--★★ギネマウア★★:あの国につくのもそれが理由かしら<br>望んでか望まずか
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_620014")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:ほおお<br>家族想いだこと
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A900_620015")

	change_face(Actor002,"Smile")

	--★★ギネマウア★★:ギネヴィアみたいね
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_620016")

	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:ひええ。私？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A900_620017")

-- ▼直接出力
 --[[CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_04)
wait_time(0.3) ]]
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:望まず<br>こんな所まで来てしまって
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_620018")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_05)
set_chara_pos_resetting(Actor001,CharaPos113011_04_003)
PlayActionDirect(Actor001,"to_Sit01")
wait_time(0.6)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:…家族想いで？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A900_620020")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor002,"to_Sewing02")
setup_small_camera_start(CUT_02)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:そんな妹だったら<br>姉をこんなふうに働かせないかぁ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_620022")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_06)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:お姉ちゃんのイジワル～っ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A900_620024")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
set_chara_pos_resetting(Actor001,CharaPos113011_04_004)
PlayActionDirect(Actor001,"to_Sleep02")
PlayActionDirect(Actor002,"to_Sewing01")
setup_small_camera_start(CUT_02)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:見かけ倒しで、父の仇討ちしたくて<br>…金色の飾りつけ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A900_620026")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_07)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:わたしみたい
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A900_620028")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:勝ち目なさげな戦いしてて<br>弱い自分にうんざりしちゃって
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A900_620029")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_08)
wait_time(0.3)
-- ▲直接出力

	--★★ギネヴィア★★:わたしにはお姉ちゃんがいたケド<br>彼には、どうなんだろう
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A900_620030")


	--★★ギネヴィア★★:誰か、となりにいるのかな
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A900_620031")


	--★★ギネヴィア★★:おしゃべり、してみたいな
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A900_620032")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_09)
wait_time(1.5)
change_face(Actor001,"Smile")
-- ▲直接出力
-- ▼直接出力
fadeout(255, 255, 255, 1.0, 1.5)
	wait_time(2.0)
off_screencolor()
	stillAnime.SetActive(true)
	fadein(1.5)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end
-- ▲直接出力

	--★★ギネヴィア★★:いってきます<br>一千年の遠い旅
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_620034")


	--★★ギネヴィア★★:さびしかったら泣いちゃうかもしれないけど
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_620035")


	--★★ギネヴィア★★:あなたがわたしを変えてくれたから<br>もう強がらなくて良くなったんだ
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_620036")


	--★★ギネヴィア★★:飾らなくて良くなったんだ<br>だからね、だいじょうぶ
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_620037")


	--★★ギネヴィア★★:路銀で困ったりもしないよ
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_620038")


	--★★ギネヴィア★★:だってね、ノワール<br>わたしすっごくリッチになったもん
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_620039")


	--★★ギネヴィア★★:にっしっし…♪
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_620040")


	--★★ギネヴィア★★:金ぴかの思い出でいっぱいだからね
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_620041")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
	CloseTalkWindow()
	signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end
fadeout(255, 255, 255, 1.0, 2.0)
	wait_time(3.0)
--stillAnime.SetActive(false)

-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10101015", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("10101015_1", "content_still_10101015_image", "101010150_StillImage")
load_ui_effect_preload("content_still_10103012_anim", "10103012_StillAnim", nil, nil, nil, "Root")
set_object_preload("content_prop_10108001", "10108001_PropModel", true)
load_image_preload("10103023", "content_still_10103023_image", "101030230_StillImage")
load_image_preload("10103024", "content_still_10103024_image", "101030240_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(113011)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName113011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
