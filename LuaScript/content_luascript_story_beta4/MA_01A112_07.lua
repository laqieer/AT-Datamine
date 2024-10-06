-- このluaスクリプトは、MA_01A112_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_03","111013_03_h")
Include("content_adv_advsmall_111013_03","Template111013_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111013_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111013_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_004)
	InitializeTemplateRandomCamera111013_03()
	InitializeTemplate111013_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401039","001","401039001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★フレン★★:このままじゃ<br>ひとりになるよ、ルーシャスくん
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_070002")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ルーシャス★★:産まれてこのかた群れたつもりはないが
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070003")

-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
Appear(Actor003)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★フレン★★:物言わぬ抜け殻と世界の侵食者しか<br>ここにはいなくなる、誰もいなくなる
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_070004")

-- ▼直接出力
se_play("SE_ADV_MA_01B109_11_Door")
wait_time(2.0)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to Bow")

	--★★ローマ兵士_上位★★:報告いたします！
	Talk(Actor004,"NPCNAME_0122","speech","L","MA_01A112_070006")

-- ▼直接出力
set_common_look_at(Actor002,Actor004)
-- ▲直接出力

	--★★ローマ兵士_上位★★:兵士、および我が領民が続々とカレドニアを離れ<br>ログレス領へ亡命しようとしています！
	Talk(Actor004,"NPCNAME_0122","speech","L","MA_01A112_070007")


	--★★ルーシャス★★:放っておけ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ヴェルナルス大将軍★★:ルーシャス様
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","MA_01A112_070010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ルーシャス★★:魔女の根源を手中に収めた時点で<br>バルバロイの増殖速度は以前の比にならぬ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070011")


	--★★ルーシャス★★:弱き者は縋ればよい<br>騎士王や継承者という見栄えする飾りに
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070012")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ヴェルナルス大将軍★★:ルーシャス様、それは――
	Talk(Actor003,"CHRNAME_VERNARTH","speech","L","MA_01A112_070014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ルーシャス★★:下がれ。将軍
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070015")

	change_face(Actor001,"Normal")

	--★★ルーシャス★★:さっさとあの学園を潰して参れ<br>バルバロイはいくら使っても構わぬ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070016")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor004)
Hide(Actor003)
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,true)
lookat_weight(Actor001,0.5,0.03,0.7,0)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:フレン、余は先日初めて登山をしてね<br>トモダチができたんだ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:トモダチ──継承者ノワールのこと？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_070019")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ルーシャス★★:だがね継承者では<br>やはり世界は救えないこともわかった
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070020")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:継承者が目指すのは平和という現状維持<br>余が目指すはバルバロイによる進化だ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070021")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★フレン★★:バルバロイが人間を喰らい尽くして<br>終わった世界でなにが進化するっていうの
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_070022")


	--★★ルーシャス★★:もし仮に、継承者が勝利したとして<br>世界に横たわる問題がひとつでも解決するかね？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フレン★★:平和になるよ…？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_070024")


	--★★ルーシャス★★:繰り返されてきた戦争や貧困、分断や飢餓や病…<br>ひとつとしてなくせると思うかね？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070025")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★フレン★★:…バルバロイならなんとかできるっていうの？<br>みんな侵食されてしまって人のなにが進化するの？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_070026")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★ルーシャス★★:バルバロイは群体だ。互いに争うことはない<br>つまらぬ戦も領土争いも裏切りも起き得ない
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070027")


	--★★ルーシャス★★:病や飢餓には無縁<br>キズすらも縫い合わせてくれる
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070028")

	PlayAction(Actor002,"to  Std_No")

	--★★フレン★★:…なにもなくなるね<br>心配なことは…なにも
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_070029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:そう。人対人、人対バルバロイなどの<br>種族間の不毛な争いや過ちなど
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070030")


	--★★ルーシャス★★:いっさい起こさず…
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070031")


	--★★ルーシャス★★:頑強な肉体と従順な本能のみをもち<br>不眠不休、永劫に近い命を宿す存在となりえる
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ルーシャス★★:人類種の進化を促す<br>それは平和的だとは思わぬか？
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A112_070033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★フレン★★:そうだね………ルーシャスくん<br>人間の罪を罰し、人間を浄化しようとしてる
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_070034")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力

	--★★フレン★★:神様みたいだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A112_070036")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401039","001","401039001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
