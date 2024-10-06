-- このluaスクリプトは、MA_01B900_61.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_03","110101_03_h")
Include("content_adv_advsmall_110101_03","Template110101_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_03_MA01B900_61_Controller","to Std_Loop",CameraAssetBundleName110101_03,CameraPos110101_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_MA01B900_61_Controller","to Std_Loop",CameraAssetBundleName110101_03,CameraPos110101_03_001)
	InitializeTemplateRandomCamera110101_03()
	InitializeTemplate110101_03()
-- ▼直接出力
CUT_01 = cat_template_camera("P10_Cam")
CUT_02 = cat_template_camera("P11_Cam")
CUT_03 = cat_template_camera("P12_Cam")
CUT_04 = cat_template_camera("P13_Cam")
CUT_05 = cat_template_camera("P14_Cam")
CUT_06 = cat_template_camera("P15_Cam")
CUT_07 = cat_template_camera("P16_Cam")
CUT_08 = cat_template_camera("P17_Cam")
CUT_09 = cat_template_camera("P18_Cam")
CUT_10 = cat_template_camera("P19_Cam")
CUT_11 = cat_template_camera("P20_Cam")
CUT_12 = cat_template_camera("P21_Cam")
CUT_13 = cat_template_camera("P22_Cam")
CUT_14 = cat_template_camera("P23_Cam")
CUT_15 = cat_template_camera("P24_Cam")
CUT_16 = cat_template_camera("P25_Cam")
seihai = setup_prop_object(10201022)
set_pos(seihai,{0,2.611,-9.087})
off_active(seihai)
Ef_Holy_Grail_ForcefulLight = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)
set_pos(Ef_Holy_Grail_ForcefulLight,{0,3.122,-5.367})
diploma = setup_prop_object(10130026)
diploma_offset = {-0.157, -0.1397, -0.0147,180,90,283}
on_parent(diploma,Actor002, "J_Hand_R",diploma_offset)
RndCamera001 =  CUT_01
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_02)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ランスロット★★:卒業証書授与<br>ノワール殿
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610002")


	--★★ランスロット★★:キャメロット騎士学術院における<br>全過程を修了したことを証する
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610003")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_03)
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…もう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610005")


	--★★ランスロット★★:もうだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610006")


	--★★ノワール★★:早くないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610007")


	--★★ランスロット★★:早くない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:早いだろ<br>一年経ってないし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610010")


	--★★ランスロット★★:たしかに、早いかもしれないが…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610011")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_04)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Smile")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:──俺が手渡したかったんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610013")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_05)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to_Std01_loop_1")
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Surprise")
-- ▲直接出力
-- ▼直接出力
wait_time(2.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_06)
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Normal")
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to_Receive01_start")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:………ありがとう。ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610015")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to_HandOver01_start")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…すまなかった。ノワール<br>今まで。本当に
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610017")


	--★★ランスロット★★:ありがとう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610019")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
off_parent(diploma)
-- ▲直接出力
-- ▼直接出力
off_active(diploma)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_07)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to_Std01_loop_2")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to_Std01_loop_1")
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:──この学園で
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610023")


	--★★ノワール★★:ようやくわかった気がするんだ<br>本当のことが
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610024")


	--★★ノワール★★:なぜ父さんや母さんが<br>俺に武器を手に入れさせたかったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610025")


	--★★ランスロット★★:…どうしてだ？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610026")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_01)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to_Thinking01_loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ノワール★★:ずっと考えてた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610027")


	--★★ノワール★★:どうして妖精ニニアンは──父さんは…<br>俺を継承者にしたのか、って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610028")


	--★★ノワール★★:断片的な記憶だけしか垣間見れなくて<br>はっきりとした結論が出ずにいた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610029")


	--★★ノワール★★:でも、辿り着いてみれば<br>なんのことはない…普通の事情だった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610030")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_08)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to_Thinking01_end")
-- ▲直接出力

	--★★ランスロット★★:………<ruby=ニニアン>自ら</ruby>の娘であるディナタンを<br>守ってもらいたかったからか…？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610031")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to_Nod01_start")
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
set_camera_nearclip(CUT_09, 4.7)
-- ▲直接出力
-- ▼直接出力
set_camera_farclip(CUT_09, 10.0)
-- ▲直接出力
-- ▼直接出力
on_active(seihai)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_Holy_Grail_ForcefulLight) 
-- ▲直接出力
-- ▼直接出力
play_particle(Ef_Holy_Grail_ForcefulLight)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_09)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ノワール★★:将来、聖域化に際しディナタンが犠牲になるのを<br>なんとしても防ぎたかったニニアンは──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610033")


	--★★ノワール★★:近親者を継承者とし<br>ディナタンを守護してもらえるよう願った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610034")


	--★★ノワール★★:父さんはその願いを叶えるべく聖杯を使うために<br>妖精殺しをしなければならなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610035")


	--★★ランスロット★★:咎人の師匠ではディナタンの傍にはいられない…<br>だからノワールにその願いを託したと…？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610036")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
off_active(seihai)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_Holy_Grail_ForcefulLight)
-- ▲直接出力
-- ▼直接出力
stop_particle(Ef_Holy_Grail_ForcefulLight)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_10)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to_Std01_loop_1")
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:だが師匠がそこまでする必要があるか？<br>妖精のために咎を被ってまで──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610037")


	--★★ノワール★★:父さんは<br>危惧していたのかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610038")


	--★★ノワール★★:いずれ、妖精殺しの息子として追われ<br>ブライアンのもとに身を寄せた俺は…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610039")


	--★★ノワール★★:必ずカレドニアとの軋轢に巻き込まれる<br>ディナタンとともにバルバロイに襲われる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610040")


	--★★ノワール★★:ならば重い枷だとしても
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610041")


	--★★ノワール★★:ランスロットを追って<br>円卓の騎士を夢見続けた俺に…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610042")


	--★★ノワール★★:生き抜く力を…騎士としての道を<br>敷いてくれたのかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610043")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_11)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:………とんだ親バカだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610045")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:妖精ニニアンに継承者としての素養を<br>見出されていた可能性もある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610046")


	--★★ランスロット★★:継承者としての運命を歩むかどうか<br>その選択はお前に委ねたわけだが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610047")


	--★★ランスロット★★:「親が子を守りたい」と願う<br>本当に普通の…家庭事情だな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610048")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_12)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だけど、そのおかげで<br>俺はあんたに並ぶことができた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610049")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_13)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to_TurnBack01_start")
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0, -100, 0,0.6)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:また──先に行ってしまうけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610050")


	--★★ランスロット★★:悔いはない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610051")

	change_face(Actor001,"Smile")

	--★★ノワール★★:格好つけずに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610052")


	--★★ランスロット★★:………
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610053")

	change_face(Actor002,"Smile")

	--★★ランスロット★★:少しだけ未練がある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610055")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:未練？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610056")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to_TurnAround01_start")
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Normal")
-- ▲直接出力
-- ▼直接出力
wait_time(1.4)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:………決闘の勝敗が、まだだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610058")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…勝ち逃げする気だと思っていたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_610059")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
Appear(Actor001)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_14)
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0, 0, 0,0.3)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to_Std01_loop_2")
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ランスロット★★:師匠が言ってたな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610060")


	--★★ランスロット★★:「<ruby=イミテーション>金色のコート</ruby>は名乗りを経て<br><ruby=オリジナル>お前の本物</ruby>と成ったんだ」と
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610061")

-- ▼直接出力
setup_small_camera_start(CUT_15)
-- ▲直接出力

	--★★ランスロット★★:「みな、お前が継いでくれるのを信じ<br>多くを託す」のだと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610063")


	--★★ランスロット★★:ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610064")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_16)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力

	--★★ランスロット★★:………決闘だ。ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_610065")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10201022)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)
setup_prop_object_preload(10130026)
diploma_offset = {-0.157, -0.1397, -0.0147,180,90,283}
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110101_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
