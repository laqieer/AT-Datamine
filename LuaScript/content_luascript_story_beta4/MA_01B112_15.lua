-- このluaスクリプトは、MA_01B112_15.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_004)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115061)
	Actor001 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101027","001","101027001")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:お爺様に逆らったと聞いたけど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150002")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "否定")
-- ▲直接出力

	--★★フィエナ★★:『父なる彼の遺児』を護ろうとしただけだよ<br>あなたたちと同じく
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B112_150003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:そう
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150004")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★フィエナ★★:穢れた聖杯で継承者を侵蝕して<br>どうするつもりだったの？
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B112_150005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:継承者としての枷を<br>外して差し上げるためよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150006")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "激怒")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★フィエナ★★:ガラハッドが<br>大変なことになっちゃったんだよ…！？
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B112_150007")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エクセリア", "怒り")
-- ▲直接出力

	--★★エクセリア★★:継承者という器なら耐えられたはずよ<br>可能性の話ではあるけどね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150008")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フィエナ★★:わからないよ…！彼らを護るんでしょ？<br>魔女やバルバロイの味方してどうするの！？
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B112_150009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エクセリア★★:継承者の枷は重く果てない<br>その責務から解放して差し上げなきゃならない
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エクセリア★★:バルバロイが世界を覆うその日までに
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150011")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力

	--★★フィエナ★★:…そうならないように<br>聖杯と継承者を揃えたんだよ
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B112_150012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:その奇跡は起こらない<br>わかるでしょう、あなたなら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150013")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★フィエナ★★:今のままならね！<br>でも取り戻してやるからっ！
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B112_150014")

-- ▼直接出力
setup_small_camera_start(Camera002)
 --PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エクセリア★★:銀卓騎士団が妨げるわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150015")

-- ▼直接出力
 --setup_small_camera_start(Camera003)
 --PlayPartVoice("ディンドラン", "挨拶")
-- ▲直接出力

	--★★ディンドラン2D★★:お静かに
	Talk(Actor004,"CHRNAME_DINDRANE","speech","L","MA_01B112_150017")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,0.3)
wait_time(0.3)
Appear(Actor003)
set_pos(Actor003,{-0.3,0,11.5})
set_rot(Actor003,{0,115,0})
setup_small_camera_start(RndCamera001)
wait_time(0.3)
fadein(0.3)
set_pos(Actor003,{-0.3,0,11.5})
set_rot(Actor003,{0,115,0})
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{1.9,0,10.5},1.5)
wait_time(1.3)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(1)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★エクセリア★★:お静かに。フィエナ？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150018")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★フィエナ★★:エクセリアが答えを教えてくれないからでしょ<br>いつまでたっても、ずっとずっと…！
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B112_150019")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "悩む")
-- ▲直接出力

	--★★ディンドラン★★:………正しいと<br>信じきれないのかもわかりませんね
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B112_150020")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フィエナ★★:え…？
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B112_150021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:…歴史の最適解は<br>勝者が決めるものよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150022")


	--★★エクセリア★★:銀卓と円卓、どちらが正しいか<br>私たちの解釈は不要なの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150023")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ディンドラン★★:勝敗に委ねると？
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B112_150024")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:………それも釈然としないけどね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150025")

-- ▼直接出力
 --PlayPartVoice("ディンドラン", "挨拶")
-- ▲直接出力

	--★★ディンドラン★★:私はバルバロイの呻きに耳を傷める世界より<br>…貴方と静かに語らえる日々の方が好きですよ
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B112_150026")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:私の主は銀卓の脚<br>産み育ててくれた恩義を返す
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力

	--★★エクセリア★★:その矜持に<br>一片の曇りもない
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_150028")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115061)
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101027","001","101027001")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
