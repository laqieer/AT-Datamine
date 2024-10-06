-- このluaスクリプトは、MS_002_091.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100021_04","100021_04_h")
Include("content_adv_advsmall_100021_04","Template100021_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100021_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_Controller","to Std_Loop",CameraAssetBundleName100021_04,CameraPos100021_04_001)
	Camera002 = SetPlayerTemplate("Actor002",44,CharaPos100021_04_013,CameraAssetBundleName100021_04,CameraPos100021_04_013)
	Camera003 = SetTemplate("Actor003",nil,CharaPos100021_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleName100021_04,CameraPos100021_04_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos100021_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName100021_04,CameraPos100021_04_005)
	Camera005 = SetTemplate("Actor008",nil,CharaPos100021_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName100021_04,CameraPos100021_04_004)
	Camera006 = SetTemplate("Actor009",nil,CharaPos100021_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_Controller","to Std_Loop",CameraAssetBundleName100021_04,CameraPos100021_04_006)
	InitializeTemplateRandomCamera100021_04()
	InitializeTemplate100021_04()
-- ▼直接出力
cam = {}
local num = 0
local camera
for i = 1 , 11 do
    num = i + 9
    camera = "P" .. num .. "_Cam"
    if i == 4 then
cam["CUT" .. num] = cat_template_camera(camera,Actor002)
    else
cam["CUT" .. num] = cat_template_camera(camera)
    end
end
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
RndCamera001 = CUT10
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor009)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.8,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
load_image("201010790", "content_still_20101079_image", "201010790_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101050190", "content_still_10105019_image", "101050190_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("201010290", "content_still_20101029_image", "201010290_StillImage")
load_image("201010300", "content_still_20101030_image", "201010300_StillImage")
load_image("201010301", "content_still_20101030_image", "201010301_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("201010260", "content_still_20101026_image", "201010260_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Noon_Present")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100021)
	Actor001 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	Actor003 = InitializeCharacter_3D("101002","002","101002002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101001","005","101001005","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	Actor006 = InitializeCharacter_2DOnly("101070","001","101070001")
	Actor007 = InitializeCharacter_TextOnly()
	Actor008 = InitializeCharacter_3D("101035","003","101035003","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor009")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(cam.CUT11)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0002")
-- ▲直接出力

	--★★アルハン★★:…見えるか
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0910003")


	--★★アルハン★★:壁面に敷き詰められた無数の<dot>箱</dot>が
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0910004")

-- ▼直接出力
setup_small_camera_start(cam.CUT12)
-- ▲直接出力

	--★★アルハン★★:ここ<ruby=アカシック・ノア>六千年の武器庫</ruby>には<br>来たるバルバロイの襲来に備えて──
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0910006")


	--★★アルハン★★:あらゆる可能性を<br>あの箱に納めている
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0910008")


	--★★アルハン★★:ゆえに、ここは『箱舟』
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0910011")

	open_select_window_tag(Actor002,"Normal","MS_002_0910013")
	if is_select(1) then
		goto Block1_1
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
--エフェクト開始
on_cameraframe(2) --カメラ四隅にエフェクトを出す
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("201010790", 0.0, 0.0, 0.0) --回想スチルを表示
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0007")
-- ▲直接出力

	--★★アルハン★★:キサマもノワールとして生きた際<br>廃都サラスにて名前だけは聞いたはずだ
	Talk(Actor001,"NPCNAME_0313","simple","N","MS_002_0910017")


	--★★アルハン★★:押し寄せるバルバロイの波を<br>乗り越えるためにあつらえた舟──
	Talk(Actor001,"NPCNAME_0313","simple","N","MS_002_0910018")


	--★★アルハン★★:バルバロイ根絶後に<br>世界を復活させるための種子が内包されている
	Talk(Actor001,"NPCNAME_0313","simple","N","MS_002_0910019")


	--★★アルハン★★:六千年前の神々の遺物だ<br>経緯はいずれ語ろう
	Talk(Actor001,"NPCNAME_0313","simple","N","MS_002_0910020")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
--スチル終了
setup_small_camera_start(cam.CUT13)
hide_image()
--エフェクト終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力

	--★★アルハン★★:キサマは<br>それらすべてを守ったのだ
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0910021")


	--★★アルハン★★:そして、自分の記憶すら守り抜いた<br>大したものだ
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0910022")

-- ▼直接出力
setup_small_camera_start(cam.CUT14)
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0002")
-- ▲直接出力

	--★★ロンギヌス★★:<%player>さんの<br>ここ数日間の記憶は失われていないのですね…？
	Talk(Actor008,"CHRNAME_LONGINUS","speech","L","MS_002_0910023")

-- ▼直接出力
PlayPartVoiceDirect("アルハン","0009")
-- ▲直接出力

	--★★アルハン★★:<%player>の高まった力は<br>過去において、敵の排除を早めた
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0910024")


	--★★アルハン★★:ゆえに潜行時間は最短で済み<br>キサマの記憶は無事なままとなったのだ
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0910025")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★レーヴァテイン★★:………ふふ。よくもまあ都合良く
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0910027")


	--★★？？？★★:そして、アナタのおかげで──
	Talk(Actor007,"CHRNAME_NAMELES","speech","L","MS_002_0910029")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(cam.CUT15)
Appear(Actor004)
PlayActionDirect(Actor004,"to WalkEnd_pose")
wait_time(1)
PlayActionDirect(Actor004,"to WalkEnd")
wait_time(1)
-- ▲直接出力

	--★★ティルフィング★★:私がここにいます
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MS_002_0910031")

-- ▼直接出力
CloseTalkWindow()
local TURN_TIME = 0.6
local WAIT_TIME = 0.1
local SPACE_TIME = 0.2
setup_small_camera_start(cam.CUT16)
lookat_delay_weight_reset(Actor002,1.0)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,224,TURN_TIME)
wait_time(WAIT_TIME)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,-165,TURN_TIME)
wait_time(WAIT_TIME)
PlayActionDirect(Actor008,"to Wlk")
turn_chara(Actor008,172,TURN_TIME)
wait_time(WAIT_TIME)
wait_time(SPACE_TIME)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1.0)
lookat_delay_weight(Actor002, {0.8, 0.1, 0.8, 0.2} , 1)
wait_time(WAIT_TIME)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(WAIT_TIME)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(WAIT_TIME)
PlayActionDirect(Actor008,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","swim_0002")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ティルフィング★★:はじめまして、ですね<br>はじめてのような気はしませんが
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MS_002_0910032")


	--★★ティルフィング★★:…私の潜在的な心残りを<br>アナタが救済してくださいました
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MS_002_0910033")


	--★★ティルフィング★★:ゆえに私はようやく<br>現代に帰還できた
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MS_002_0910034")

-- ▼直接出力
setup_small_camera_start(cam.CUT17)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Bow")
PlayPartVoiceDirect("ティルフィング","0036")
-- ▲直接出力

	--★★ティルフィング★★:…ありがとうございます<br>積もる話は、これからゆっくりと
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MS_002_0910035")

-- ▼直接出力
Hide(Actor001)
Appear(Actor009)
PlayActionDirect(Actor009,"to Std_start_pose")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ティルフィング★★:アナタが世界を<br>続けてくださいましたから
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MS_002_0910036")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(cam.CUT18)
PlayActionDirect(Actor009,"to Std_start")
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0032")
-- ▲直接出力

	--★★アルハン2★★:…だが、敵の再来は近い
	Talk(Actor009,"NPCNAME_0313","speech","L","MS_002_0910037")


	--★★アルハン2★★:早急に『根源の武器』の聖遺物を<br>見つけねばなるまいな
	Talk(Actor009,"NPCNAME_0313","speech","L","MS_002_0910038")

-- ▼直接出力
CloseTalkWindow()
show_image("101050190", 0.0, 0.0, 0.8,true,false)
wait_time(0.8)
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MS_002_0910040")
	if is_select(1) then
		goto Block2_1
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","0008")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ティルフィング★★:アナタが体験した歴史のとおり──
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MS_002_0910044")

	goto Block2end

::Block2end::
	change_face(Actor004,"Normal")

	--★★ティルフィング★★:アロンダイトをはじめとした『<ruby=オーセンティック>根源の武器</ruby>』は<br>バルバロイの封として機能していました
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MS_002_0910045")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0025")
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★ロンギヌス★★:ですが現代にてバルバロイの封が解けると同時に<br>『<ruby=オーセンティック>根源の武器</ruby>』たちは世界中へ離散した…
	Talk(Actor008,"CHRNAME_LONGINUS","speech","L","MS_002_0910047")

	change_face(Actor008,"Normal")

	--★★ロンギヌス★★:それを見つけられれば<br>新たな時代へ潜行し、武器を増やせる…
	Talk(Actor008,"CHRNAME_LONGINUS","speech","L","MS_002_0910049")


	--★★ティルフィング★★:アナタがアロンダイトの聖遺物へ<br>潜ったように
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MS_002_0910050")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0049")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★レーヴァテイン★★:<ruby=わたしたち>その時代における最初の武器</ruby>が導き手となって
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0910051")

-- ▼直接出力
setup_small_camera_start(cam.CUT20)
CloseTalkWindow()
hide_image(0.8)
wait_time(0.8)
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ティルフィング★★:………いずれ刻が来たるまでお待ちを<br>その際は、私たちが必ず──
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MS_002_0910053")


	--★★ティルフィング★★:教えて、差し上げます
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MS_002_0910054")

-- ▼直接出力
CloseTalkWindow()
bgm_play("BGM_Area_Noon_Present")
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
show_image("201010290", 0.0, 0.0, 0.0,true,false)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0033")
-- ▲直接出力

	--★★レーヴァテイン★★:今になって思えば<br>ムカつく話
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910057")


	--★★レーヴァテイン★★:あのとき<br>私が迎えに行ったせいで
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910058")


	--★★レーヴァテイン★★:あなたは自分の記憶を失って<br>他人の痛みを請け負うことになった
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910059")


	--★★レーヴァテイン★★:戸惑うことなく<br>名前を教えてくれたあなたを──
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910060")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0043")
-- ▲直接出力

	--★★レーヴァテイン★★:私が破滅させた
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910061")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0037")
-- ▲直接出力

	--★★レーヴァテイン★★:ごめん…イヤ、だよね…<br>学生生活の記憶が消えるなんて
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910062")


	--★★レーヴァテイン★★:一生の思い出として残る<br>大切な記憶もあったはずなのに
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910063")


	--★★レーヴァテイン★★:私は…その名の通り『<ruby=レーヴァテイン>破滅の剣</ruby>』
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910064")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, FADE_TIME_FAST)
wait_time(FADE_TIME_FAST)
show_image("201010300", 0.0, 0.0, 0.0,true,false)
fadein(FADE_TIME_FAST)
wait_time(FADE_TIME_FAST)
-- ▲直接出力

	--★★レーヴァテイン★★:大嫌いだ<br>救いようのないこの名前
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910067")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0050")
-- ▲直接出力

	--★★レーヴァテイン★★:………でも
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910068")


	--★★レーヴァテイン★★:でもね、<%player>
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910069")


	--★★レーヴァテイン★★:救いようのない私は<br>あなたを救いたい
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910070")


	--★★レーヴァテイン★★:どれだけ、もがいてでも
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910071")


	--★★テロップ★★:もう、うたたねも最後
	Talk(Actor005,"telop","simple","N","MS_002_0910072")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0010")
-- ▲直接出力

	--★★レーヴァテイン★★:あなたのおかげで<br>自由に笑えそうだから
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910073")


	--★★レーヴァテイン★★:だって破滅の継承は<br>あなたが最後にしてくれるんでしょ？
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910074")


	--★★レーヴァテイン★★:まさしく<br><ruby=インヘリター>最後の継承者</ruby>
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910075")

-- ▼直接出力
show_image("201010301", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0036")
-- ▲直接出力

	--★★レーヴァテイン★★:続けてくれて<br>ありがとう
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910078")


	--★★レーヴァテイン★★:破滅の先を、迎えに行こう
	Talk(Actor003,"CHRNAME_LAEVATEIN","simple","N","MS_002_0910079")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
show_image("201010260", 0.0, 0.0, 0.0,true,false)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★テロップ★★:「きみと、隣の席になった」
	Talk(Actor005,"telop","simple","N","MS_002_0910093")

-- ▼直接出力
voice_play("VO_101070001_sp_0001_1")
-- ▲直接出力

	--★★フライクーゲル★★:ダーリン
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910094")


	--★★テロップ★★:「『そばにいてごめんね』とか」
	Talk(Actor005,"telop","simple","N","MS_002_0910095")


	--★★フライクーゲル★★:もう笑って逃げるの、やめるよ
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910096")


	--★★テロップ★★:「絶対にきみを、自由にするよ」
	Talk(Actor005,"telop","simple","N","MS_002_0910097")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0057")
-- ▲直接出力

	--★★フライクーゲル★★:わたしはきみを<br>自由にはできない
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910098")


	--★★フライクーゲル★★:きみはダーリンだけど<br>ダーリンじゃなくて
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910099")


	--★★フライクーゲル★★:過去は消えて、未来は決められてる<br>不自由のなかで戦わなきゃいけないから
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910100")


	--★★フライクーゲル★★:だからこそわたしは<br><dot>今の</dot>きみの隣にいたい
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910101")


	--★★フライクーゲル★★:………<br>オーバーな言いかただけど
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910103")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0006")
-- ▲直接出力

	--★★フライクーゲル★★:さよなら。ダーリン
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910104")


	--★★テロップ★★:「いつもハズしてばっかり」
	Talk(Actor005,"telop","simple","N","MS_002_0910105")


	--★★フライクーゲル★★:はじめまして<br>フライクーゲルです
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910106")


	--★★フライクーゲル★★:わたしと
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910107")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0042")
-- ▲直接出力

	--★★フライクーゲル★★:友達から、はじめてください
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910109")

	open_select_window_tag(Actor002,"Normal","MS_002_0910111")
	if is_select(1) then
		goto Block3_1
	end

::Block3_1::
	CloseTalkWindow()
	change_face(Actor005,"Normal")

	--★★テロップ★★:「その場のテンションとか<br>大事なコトバを言うタイミングとか」
	Talk(Actor005,"telop","simple","N","MS_002_0910115")

	goto Block3end

::Block3end::
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0008")
-- ▲直接出力

	--★★フライクーゲル★★:………──うんっ
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910117")

	change_face(Actor005,"Normal")

	--★★テロップ★★:「だけどひとりで行くきみに<br>言ってあげなきゃ」
	Talk(Actor005,"telop","simple","N","MS_002_0910118")

-- ▼直接出力
voice_play("VO_101070001_sp_0001_1")
-- ▲直接出力

	--★★フライクーゲル★★:ダーリン
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910119")


	--★★フライクーゲル★★:<ruby=そばにいるからね>『スタンバイ・ユー』</ruby>
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910120")

-- ▼直接出力
CloseTalkWindow()
wait_time(2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0048")
-- ▲直接出力

	--★★フライクーゲル★★:ハズいね、コレ
	Talk(Actor006,"CHRNAME_FREIKUGEL","simple","N","MS_002_0910123")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
cam = {}
local num = 0
local camera
for i = 1 , 11 do
    num = i + 9
    camera = "P" .. num .. "_Cam"
    if i == 4 then
    else
    end
end
RndCamera001 = CUT10
load_image_preload("201010790", "content_still_20101079_image", "201010790_StillImage")
load_image_preload("101050190", "content_still_10105019_image", "101050190_StillImage")
load_image_preload("201010290", "content_still_20101029_image", "201010290_StillImage")
load_image_preload("201010300", "content_still_20101030_image", "201010300_StillImage")
load_image_preload("201010301", "content_still_20101030_image", "201010301_StillImage")
load_image_preload("201010260", "content_still_20101026_image", "201010260_StillImage")
preload_sound("BGM_Area_Noon_Present")
	InitializeLoad_Preload()
	load_area_scene_preload(100021)
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101002","002","101002002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101001","005","101001005","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_2DOnly_Preload("101070","001","101070001")
	InitializeCharacter_3D_Preload("101035","003","101035003","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor009")
	system.PreLoadRequest(CameraAssetBundleName100021_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
