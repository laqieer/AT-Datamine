-- このluaスクリプトは、CO_101012_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
Hide(Actor001)
set_pos(Actor001,{-0.425,0,-3.282})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-0.53,0,0.27})
turn_chara(Actor003,130,0)
set_pos(Actor004,{0.282,0,0.224})
turn_chara(Actor004,140,0)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
local mobs = {"m010","m011","m012","m050","m051"}
local mob
for i = 1 , #mobs do
    mob = get_object(mobs[i])
    set_pos(mob,{0,-20,0})
end
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0049")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:はぁ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010002")

-- ▼直接出力
local gopos = {1.78, 0, -3.193}
CloseTalkWindow()
Appear(Actor001)
turn_lookat_position(Actor001, gopos, 0)
setup_small_camera_end(Camera002)
setup_small_camera_start(RndCamera090)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001, gopos, 2)
wait_time(1)
setup_small_camera_end(RndCamera090)
setup_small_camera_start(Camera001)
wait_time(1)
turn_chara(Actor001,12,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0063")
-- ▲直接出力

	--★★ノワール★★:どうしたんだ、ディナタン<br>ため息なんかついて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010004")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:兄さん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010005")

	open_select_window_tag(Actor001,"Normal","CO_101012_01010007","CO_101012_01010008","CO_101012_01010009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園で<br>なにか気になってることでもあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010011")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:えええ！？<br>兄さん、なんでわかっちゃうの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:これくらいわかるさ<br>兄妹なんだからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010013")

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:かなわないなぁ、もう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:もしかして、<br>ランスロットのことが気になるとか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010016")

-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:それは兄さんのほうでしょ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010017")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:もちろん私も<br>気にならないわけじゃないけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010018")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:私が気にしても仕方ないと思うし<br>気になってるのはもっと別のことだよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ハラでも減ったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010021")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:兄さんってば…年頃の女の子が<br>お腹空いたよ～ってため息つくと思う？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010022")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.8)
se_play("SE_ADV_CO_101012_0101_Stomach")
wait_time(2.0)
setup_small_camera_end(Camera002)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010024")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:こ、これはたまたまだから！<br>ため息の理由は、違うから！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010025")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:この学園に来てしばらく経つけど<br>どうしても学生生活に慣れなくて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010027")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:わかるよ。俺だって全然慣れないし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010028")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:でも兄さんはなんだかんだ<br>学園に馴染み始めてる感じするじゃない？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010029")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:円卓の皆さんとか、お友達もできてさ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010031")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あいつらは、友達っていうのか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010032")

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:お話しする相手がいるでしょ<br>それって素敵なことだよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010034")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:それに比べて私…<br>まだ全然、お友達ができてないんだぁ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010035")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうなのか。意外だな<br>ディナタンならすぐ友達ができると思ってたのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0040")
-- ▲直接出力

	--★★ディナタン★★:全然だよ。それどころか…<br>なんだか、避けられてるような気もするし
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010037")


	--★★ノワール★★:避けられてるって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010038")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.6)
lookat_delay_weight(Actor001,0.5,0.1,0.8,0.2,0.6)
wait_time(1)
local gopos = {-0.53, 0, 4.142}
local gopos2 = {0.247, 0, 4.165}
Appear(Actor003)
Appear(Actor004)
setup_small_camera_start(RndCamera006)
PlayActionDirect(Actor003,"to  Std_Surp")
wait_time(0.1)
PlayActionDirect(Actor004,"to  Std_Surp")
wait_time(1)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat_position(Actor003, gopos, 0.4)
wait_time(0.1)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat_position(Actor004, gopos2, 0.4)
wait_time(0.3)
slidemove(Actor003, gopos, 2)
wait_time(0.1)
slidemove(Actor004, gopos2, 2)
wait_time(0.6)
setup_small_camera_end(RndCamera006)
setup_small_camera_start(RndCamera009)
wait_time(2)
setup_small_camera_end(RndCamera009)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.1)
PlayActionDirect(Actor004,"to Std_Loop")
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor001,1.0)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…確かに、ちょっと距離は感じるかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010040")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:でしょ！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:入学してからずっとこの調子なの<br>話しかけてみようとしても上手くいかなくて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010042")


	--★★ディナタン★★:この間まで敵国の所属だったし<br>しかたないとは思うけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010043")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0025")
-- ▲直接出力

	--★★ディナタン★★:正直、ちょっとくじけそうだよ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010044")

	open_select_window_tag(Actor001,"Normal","CO_101012_01010046","CO_101012_01010047")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:気にするなよ<br>そのうちなんとかなるって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010049")

-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:もう、他人事みたいに言って！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010050")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:兄さんはいいよねぇ<br>始めっから色んな人とお知り合いになれてて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010051")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:大丈夫だ<br>俺がついてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010053")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:出ました、根拠のない励まし～
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010054")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:でも、兄さんにそう言われると<br>大丈夫な気がするから不思議だよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010055")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0049")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:はぁ～…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010057")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:…そんなに気になるなら、相談してみるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:相談って、誰に？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010059")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは、その…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010060")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:心配してもらわなくても大丈夫<br>自分のことは自分でちゃんとやれるよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010062")


	--★★ノワール★★:ディナタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010063")


	--★★ディナタン★★:これからはここで暮らしていくんだから<br>ちゃんと馴染んでいかないとだよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010064")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:私、頑張るから<br>兄さんも協力してよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_01010065")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ、わかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_01010066")

-- ▼直接出力
local trustParam = set_communication_acquired("ディナタン_コミュランク", "ディナタン_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
local mobs = {"m010","m011","m012","m050","m051"}
local mob
for i = 1 , #mobs do
end
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
