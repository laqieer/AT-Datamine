-- このluaスクリプトは、MA_01B111_15.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_05","110011_05_h")
Include("content_adv_advsmall_110011_05","Template110011_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_05_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_05,CameraPos110011_05_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_05_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_05,CameraPos110011_05_001)
	InitializeTemplateRandomCamera110011_05()
	InitializeTemplate110011_05()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:…質問していいか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力

	--★★ディナタン★★:もちろん
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:………ランスロットは<br>どういう人なんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150004")


	--★★ディナタン★★:ガラハッド<br>それ聞きたくて来たんだよね
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150005")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:な、なにを言う
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:だってお勉強できるんだもん<br>私が教えなくてもじゅうぶん
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:無論だ！<br>本腰を入れればこんなの造作もない…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:だから、きっと別のことを<br>学びたくて来たんだろうなあって
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力

	--★★ガラハッド★★:す、す、すまない<br>好意を…ダシに使ってしまったようで
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "挨拶")
-- ▲直接出力

	--★★ディナタン★★:憧れてるって、聞いたけど
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150011")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:…ガラハッドが、なるべき姿…なんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150012")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:…ランス兄ちゃんは、そうだなあ…<br>すごくすごくね？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150013")

	change_face(Actor001,"Smile")

	--★★ディナタン★★:水色な人
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150014")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:水色…？<br>透明ということか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:そうかも。濁ってないの。曇ってないの<br>透明で、水みたいに綺麗で
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150016")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:だけど強く打ち付けると鋭くて<br>穏やかなときは凄く優しくて──
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:つかみどころがない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150018")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:そう！そうなの！だからなのかなあ<br>兄さんもランス兄ちゃんの尻尾を掴もうと必死で
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150019")


	--★★ディナタン★★:ランス兄ちゃんをわかろうと追いかけて<br>今やっと追いついて
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150020")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:…流れていって、しまいそうな感じはある
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:うん。だからね、兄さんには<br>ランス兄ちゃんをしっかり引き留めて欲しいの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:ランス兄ちゃんもきっと<br>私にはわからないものをいっぱい背負って
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150023")


	--★★ディナタン★★:だけど全部を水みたいに飲み込んじゃって<br>苦しくって、でも…頼れる人も見当たらなくて
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:だから今はきっと<br>ランス兄ちゃんも穏やかでいられるんだと思うの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150025")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:………ノワール、は…どうなんだ？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150026")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:どう、って？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150027")


	--★★ガラハッド★★:彼は…どういう人なんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150028")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:聞きたいんだ？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:と、と、ともに戦う者としてだ<br>それ以上でもそれ以下でもない…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150030")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:へええ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力

	--★★ガラハッド★★:なんだその目は…！別にそんな、僕は…っ<br>け、汚らわしい、よこしまな気持ちはひとつも！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150032")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力

	--★★ディナタン★★:なにも言ってないけど
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150033")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:あっ、あっ、あーっ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150034")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力

	--★★ディナタン★★:私が兄さんのことを語ると長くなるけど、いい？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_150035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:べ、勉強させてもらおう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B111_150036")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
